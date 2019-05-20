using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LartaDemo
{
    public static class FixedWidthTextParser
    {
        public static List<string[]> ReadFile(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            return ParseLines(lines);
        }

        private static List<string[]> ParseLines(string[] lines)
        {
            List<string[]> values = new List<string[]>();
            int headerLine = -1;
            List<int[]> headerLocations = null;
            bool foundHeader = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == headerLine)
                {
                    foundHeader = true;
                    headerLocations = ParseHeader(line);
                }
                else if (foundHeader)
                {
                    if (HasNumericFirst(line))
                        values.Add(ParseLine(line, headerLocations));
                }
                else
                {
                    if (HasNumericFirst(line))  //only lines w/ numbers first are relevant rows
                    {
                        i--; //search rows above to find header
                        while (i > 0 && lines[i].Length == 0)
                        {
                            i--;//keep searching if there are empty lines
                        }
                        if (i == 0)
                            throw new InvalidDataException("InvalidDataException no header found");
                        headerLine = i;
                        i--;// parse headerline on first run.
                    }
                }
            }
            return values;
        }

        private static bool HasNumericFirst(string line)
        {
            // only lines starting w/ numbers are valid rows
            foreach (var c in line)
            {
                if (c != ' ')
                {
                    return int.TryParse(c.ToString(), out int result);
                }
            }
            return false;
        }

        private static string[] ParseLine(string line, List<int[]> headerLocations)
        {
            string[] s = new string[headerLocations.Count];
            // spaces define the end of each formatted text column 
            // so look for spaces that enclose the current column by looking left and right
            for (int i = 0; i < headerLocations.Count; i++)
            {
                int[] loc = headerLocations[i];
                int foundLeft = loc[0];
                int foundRight = Math.Min(loc[1], line.Length - 1);
                while (foundLeft > -1 && line[foundLeft] != ' ')
                {
                    foundLeft--;
                }
                foundLeft++;// set back to data start
                while (foundRight < line.Length && line[foundRight] != ' ')
                {
                    foundRight++;
                }

                s[i] = line.Substring(foundLeft, foundRight - foundLeft).Trim();
            }
            return s;
        }

        private static List<int[]> ParseHeader(string h)
        {
            // save off locations of header columns using start and end character 
            List<int[]> headerLocations = new List<int[]>();
            bool inWord = false;
            int[] location = new int[2];
            for (int i = 0; i < h.Length; i++)
            {
                if (inWord)
                {
                    if (h[i] == ' ')
                    {
                        if (location[0] == i - 1) location[1] = i; // allow off by 1 errors for single char header.
                        else location[1] = i - 1;
                        headerLocations.Add(location);
                        inWord = false;
                    }
                }
                else
                {
                    if (h[i] != ' ')
                    {
                        location = new int[2];
                        location[0] = i;
                        inWord = true;
                    }
                }
            }

            location[1] = h.Length - 1;
            headerLocations.Add(location);
            return headerLocations;
        }
    }
}
