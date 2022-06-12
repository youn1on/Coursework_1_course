using System.IO;
using System.Text.RegularExpressions;

namespace Labyrinths_AStar_Dijkstra.Model
{
    public static class FileOperations
    {
        /// <summary>
        /// Gets all lines of file and validates it.
        /// </summary>
        /// <returns>Content of given file</returns>
        public static string[] GetFileContent(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            bool isValidated = ValidateFile(ref lines);
            if (isValidated) return lines;
            return null;
        }

        /// <summary>
        /// Checks if filecontent matches the pattern of labyrinth.
        /// </summary>
        /// <returns>True if filecontent is valid</returns>
        public static bool ValidateFile(ref string[] content)
        {
            int length = content[0].Trim().Length;
            Regex regex = new Regex(@"^[X ]+$"); //File should consist of "X" and empty spaces only
            for (int i = 0; i < content.Length; i++)
            {
                content[i] = content[i].Trim();
                if (!regex.IsMatch(content[i]) || content[i].Length != length)
                {
                    return false;
                }
            }

            regex = new Regex(@"^(?:X )+X$");// First and last lines contain walls only.
            if (regex.IsMatch(content[0]) && regex.IsMatch(content[content.Length-1])) return true;
            return false;
        }
    }
}