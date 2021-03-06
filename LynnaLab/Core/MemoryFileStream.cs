using System;
using System.IO;

public class MemoryFileStream : Stream {
    public override bool CanRead {
        get { return true; }
    }
    public override bool CanSeek {
        get { return true; }
    }
    public override bool CanTimeout {
        get { return false; }
    }
    public override bool CanWrite {
        get { return true; }
    }
    public override long Length {
        get { return _length; }
    }
    public override long Position {
        get { return _position; }
        set { _position = value; }
    }

    public string Name {
        get { return filename; }
    }

    long _length;
    long _position;
    byte[] data;
    bool modified = false;

    string filename;

    public MemoryFileStream(string filename) {
        this.filename = filename;
        
        FileStream input = new FileStream(filename, FileMode.Open);
        _length = input.Length;

        data = new byte[Length];
        _position = 0;
        modified = false;
        input.Read(data, 0, (int)Length);
        input.Close();
    }

    public override void Flush() {
        if (modified) {
            FileStream output = new FileStream(filename, FileMode.Open);
            output.Write(data, 0, (int)Length);
            output.Close();
            modified = false;
        }
    }

    public override void SetLength(long len) {
        if (Length != len) {
            modified = true;
            byte[] newData = new byte[len];
            Array.Copy(data, newData, Math.Min(len, _length));
            data = newData;

            _length = len;
        }
    }

    public override long Seek(long dest, SeekOrigin origin) {
        switch (origin) {
            case SeekOrigin.End:
                Position = Length - dest;
                break;
            case SeekOrigin.Begin:
                Position = dest;
                break;
            case SeekOrigin.Current:
                Position += dest;
                break;
        }
        return Position;
    }

    public override int Read(byte[] buffer, int offset, int count) {
        int size = count;
        if (Position + count > Length)
            size = (int)(Length-Position);
        Array.Copy(data, Position, buffer, offset, size);
        Position = Position + size;
        return size;
    }
    public override void Write(byte[] buffer, int offset, int count) {
        if (Position + count > Length)
            SetLength(Position + count);
        Array.Copy(buffer, offset, data, Position, count);
        Position = Position + count;
        if (Position > Length)
            Position = Length;
        modified = true;
    }

    public override int ReadByte() {
        int ret = data[Position];
        Position++;
        return ret;
    }
    public override void WriteByte(byte value) {
        data[Position] = value;
        Position++;
        modified = true;
    }
}
