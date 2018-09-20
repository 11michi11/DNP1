using System.Text;

namespace StringUtility {
    class SummarizeText {

        public static string Summarize(string text) {
            if (text.Length > 20){
               string[] arr = text.Split(' ');

                StringBuilder sb = new StringBuilder("");
                int x = 0;
                while(sb.Length + arr[x].Length < 20){
                    sb.Append(arr[x]);
                    x++;
                }

                sb.Append("...");

               return sb.ToString();
            }
               // return text.Substring(0, 17) + "...";
            else
                return text;
        }
    }
}