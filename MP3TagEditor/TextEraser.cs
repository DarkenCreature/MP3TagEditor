using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3TagEditor
{
    class TextEraser
    {
        public string[] löschText;

        public TextEraser(string interpret)
        {
            löschText = new string[73];

            löschText[0] = interpret + " - ";
            löschText[1] = interpret.ToUpper() + " - ";
            löschText[2] = interpret;
            löschText[3] = interpret.ToUpper();


            // OFFICIAL VIDEO

            löschText[4] = "(Official Video)";
            löschText[5] = "[Official Video]";
            löschText[6] = "Official Video";
            löschText[7] = "(OFFICIAL VIDEO)";
            löschText[8] = "[OFFICIAL VIDEO]";
            löschText[9] = "OFFICIAL VIDEO";

            löschText[10] = "(Lyrics Video)";
            löschText[11] = "[Lyrics Video]";
            löschText[12] = "(LYRICS VIDEO)";
            löschText[13] = "[LYRICS VIDEO]";
            löschText[14] = "Lyrics Video";
            löschText[15] = "LYRICS VIDEO";

            löschText[16] = "(Lyric Video)";
            löschText[17] = "[Lyric Video]";
            löschText[18] = "Lyric Video";
            löschText[19] = "(LYRIC VIDEO)";
            löschText[20] = "[LYRIC VIDEO]";
            löschText[21] = "LYRIC VIDEO";

            löschText[22] = "(Official Music Video)";
            löschText[23] = "[OFFICIAL MUSIC VIDEO]";
            löschText[24] = "(Official Music Video)";
            löschText[25] = "[OFFICIAL MUSIC VIDEO]";

            löschText[26] = "Official Music Video";
            löschText[27] = "OFFICIAL MUSIC VIDEO";

            löschText[28] = "(Official Lyrics Video)";
            löschText[29] = "[Official Lyrics Video]";
            löschText[30] = "(OFFICIAL LYRICS VIDEO)";
            löschText[31] = "[OFFICIAL LYRICS VIDEO]";
            löschText[32] = "Official Lyrics Video";
            löschText[33] = "OFFICIAL LYRICS VIDEO";

            löschText[34] = "(Official Lyric Video)";
            löschText[35] = "[Official Lyric Video]";
            löschText[36] = "Official Lyric Video";
            löschText[37] = "(OFFICIAL LYRIC VIDEO)";
            löschText[38] = "[OFFICIAL LYRIC VIDEO]";
            löschText[39] = "OFFICIAL LYRIC VIDEO";


            // LYRICS

            löschText[40] = "(with lyrics)";
            löschText[41] = "(lyrics)";
            löschText[42] = "(with lyric)";
            löschText[43] = "(lyric)";
            löschText[44] = "[with lyrics]";
            löschText[45] = "[lyrics]";
            löschText[46] = "[with lyric]";
            löschText[47] = "[lyric]";
            löschText[48] = "with lyrics";
            löschText[49] = "with lyric";
            löschText[50] = "lyrics";
            löschText[51] = "lyric";

            löschText[52] = "(With lyrics)";
            löschText[53] = "(Lyrics)";
            löschText[54] = "(With Lyric)";
            löschText[55] = "(Lyric)";
            löschText[56] = "[With Lyrics]";
            löschText[57] = "[Lyrics]";
            löschText[58] = "[With Lyric]";
            löschText[59] = "[Lyric]";
            löschText[60] = "With Lyrics";
            löschText[61] = "With Lyric";
            löschText[62] = "Lyrics";
            löschText[63] = "Lyric";


            // Sonstiges

            löschText[64] = "Napalm Records";
            löschText[65] = " | ";
            löschText[66] = " || ";
            löschText[67] = " - ";
            löschText[68] = "\"";
            löschText[69] = "Vevo Presents: ";
            löschText[70] = "Vevo Presents";
            löschText[71] = "Vevo - ";
            löschText[72] = "Vevo";
        }

        public string EraseText(string inputString)
        {
            for (int i = 0; i < löschText.Length; i++)
            {
                inputString = inputString.Replace(löschText[i], "#");
            }

            Settings.CustomRpl crpl = new Settings.CustomRpl(Application.StartupPath + "\\");
            bool custom = crpl.TestingCustomArg();

            if (custom)
                for (int i = 0; i < crpl.arguments.Length; i++)
                    inputString = inputString.Replace(crpl.arguments[i], "#");

            inputString = inputString.Replace("  #  ", "").Replace("  # ", "").Replace(" #  ", "").Replace(" # ", "").Replace(" #", "").Replace("# ", "").Replace("#", "");

            return inputString;
        }

    }
}
