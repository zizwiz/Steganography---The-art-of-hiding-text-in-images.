using System;
using System.Collections.Generic;
using System.Drawing;

public class Encode
{

    public static void EncodeMessageInImage(Bitmap bm, Bitmap visible_bm, string password, string message)
    {
        // Initialize a random number generator.
        Random rand = new Random(NumericPassword(password));

        // Create a new HashSet.
        HashSet<string> used_positions = new HashSet<string>();

        // Encode the message length.
        byte[] bytes = BitConverter.GetBytes(message.Length);
        for (int i = 0; i < bytes.Length; i++)
        {
            EncodeByte(bm, visible_bm, rand, bytes[i], used_positions);
        }

        // Encode the message.
        char[] chars = message.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            EncodeByte(bm, visible_bm, rand, (byte)chars[i], used_positions);
        }
    }

    // Encode a byte in the picture.
    public static void EncodeByte(Bitmap bm, Bitmap visible_bm, Random rand, byte value, HashSet<string> used_positions)
    {
        for (int i = 0; i < 8; i++)
        {
            // Pick a position for the ith bit.
            int row, col, pix;
            PickPosition(bm, rand, used_positions, out row, out col, out pix);

            // Get the color's pixel components.
            Color clr = bm.GetPixel(row, col);
            byte r = clr.R;
            byte g = clr.G;
            byte b = clr.B;

            // Get the next bit to store.
            int bit = 0;
            if ((value & 1) == 1) bit = 1;

            // Update the color.
            switch (pix)
            {
                case 0:
                    r = (byte)((r & 0xFE) | bit);
                    break;
                case 1:
                    g = (byte)((g & 0xFE) | bit);
                    break;
                case 2:
                    b = (byte)((b & 0xFE) | bit);
                    break;
            }
            clr = Color.FromArgb(clr.A, r, g, b);
            bm.SetPixel(row, col, clr);

            // Display a red pixel.
            visible_bm.SetPixel(row, col, Color.Red);

            // Move to the next bit in the value.
            value >>= 1;
        }
    }


    // Pick an unused (r, c, pixel) combination.
    public static void PickPosition(Bitmap bm, Random rand,
        HashSet<string> used_positions,
        out int row, out int col, out int pix)
    {
        for (; ; )
        {
            // Pick random r, c, and pix.
            row = rand.Next(0, bm.Width);
            col = rand.Next(0, bm.Height);
            pix = rand.Next(0, 3);

            // See if this location is available.
            string key =
                row.ToString() + "/" +
                col.ToString() + "/" +
                pix.ToString();
            if (!used_positions.Contains(key))
            {
                used_positions.Add(key);
                return;
            }
        }
    }

    // Convert a string password into a numeric value.
    public static int NumericPassword(string password)
    {
        // Initialize the shift values to different non-zero values.
        int shift1 = 3;
        int shift2 = 17;

        // Process the message.
        char[] chars = password.ToCharArray();
        int value = 0;
        for (int i = 1; i < password.Length; i++)
        {
            // Add the next letter.
            int ch_value = (int)chars[i];
            value ^= (ch_value << shift1);
            value ^= (ch_value << shift2);

            // Change the shifts.
            shift1 = (shift1 + 7) % 19;
            shift2 = (shift2 + 13) % 23;
        }
        return value;
    }




}

