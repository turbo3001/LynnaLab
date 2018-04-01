using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace LynnaLab {

/// <summary>
///  This will throw an "InvalidAnimationException" whenever something unexpected happens (which
///  seems common, particularly when animations are undefined for an object).
/// </summary>
public class ObjectAnimationFrame {
    ObjectAnimation _animation;
    Data _animData;
    Data _oamData;

    public Project Project {
        get { return _animation.Project; }
    }

    List<Tuple<Bitmap,int,int>> bitmaps = new List<Tuple<Bitmap,int,int>>();

    // Number of frames this lasts
    public byte Length {
        get { return (byte)_animData.GetIntValue(0); }
    }

    public ObjectAnimationFrame(ObjectAnimation anim, Data animData) {
        _animation = anim;
        _animData = animData;

        try {

            // Note: this "index" is more like index*2, since it's added directly to the offset
            // without being multiplied first
            int oamIndex = (byte)_animData.NextData.GetIntValue(0);

            // Get entry in oam table for this object
            Data oamPtr = Project.GetData(_animation.OamTableName, oamIndex);
            _oamData = Project.GetData(oamPtr.GetValue(0));

            // Load sprite images
            int _numSprites = _oamData.GetIntValue(0);
            Data data = _oamData.NextData;

            for (int i=0; i<_numSprites; i++) {
                int y = (sbyte)data.GetIntValue(0) - 16;
                data = data.NextData;
                int x = (sbyte)data.GetIntValue(0) - 8;
                data = data.NextData;
                int tileIndex = data.GetIntValue(0) + _animation.TileIndexBase;
                data = data.NextData;
                byte flags = (byte)(data.GetIntValue(0) | _animation.OamFlagsBase);
                data = data.NextData;

                ObjectGfxHeaderData gfxHeader = _animation.ObjectGfxHeaderData;
                int origTileIndex = tileIndex;

                while (tileIndex >= 0x20) {
                    if (gfxHeader.ShouldHaveNext) {
                        gfxHeader = gfxHeader.NextGfxHeader;
                        tileIndex -= 0x20;
                    }
                    else
                        throw new InvalidAnimationException("Tileindex out of range (" + tileIndex + ")");
                }

                int tileOffset = (tileIndex&0xfe)*16;
                Stream gfxStream = gfxHeader.GfxStream;

                if (gfxStream.Length - tileOffset < 0x20)
                    throw new InvalidAnimationException("Sprite not defined in gfx data");

                gfxStream.Seek(tileOffset, SeekOrigin.Begin);
                byte[] gfxData = new byte[0x20];
                gfxStream.Read(gfxData, 0, 0x20);

                Color[] palette;
                if ((flags&7) >= 6)
                    palette = GbGraphics.GrayPalette;
                else
                    palette = Project.GetStandardSpritePalettes()[flags&7];

                Bitmap bitmap = GbGraphics.TileToBitmap(gfxData, palette, flags);
                bitmaps.Add(new Tuple<Bitmap,int,int>(bitmap,x,y));
            }
        }
        catch(InvalidLookupException e) {
            bitmaps = null;
            throw new InvalidAnimationException(e);
        }
    }

    /// <summary>
    ///  Will throw InvalidAnimationException if initialization failed earlier...
    /// </summary>
    public void Draw(Graphics g, int xPos, int yPos) {
        if (bitmaps == null)
            throw new InvalidAnimationException();

        int _numSprites = _oamData.GetIntValue(0);

        // Draw sprites in backwards order to respect priority properly
        for (int i=_numSprites-1; i>=0; i--) {
            Tuple<Bitmap,int,int> tup = bitmaps[i];
            Bitmap bitmap = tup.Item1;
            int x = tup.Item2 + xPos;
            int y = tup.Item3 + yPos;
            g.DrawImage(bitmap, x, y);
        }
    }


    // (TODO: make this return null sometimes? Not all animations loop, but there's not an easy way
    // to determine when one ends...)
    public ObjectAnimationFrame GetNextFrame() {
        return null;
    }
}

}
