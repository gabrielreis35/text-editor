using dictionary;

namespace words{
    public class Words{
        public static void ReadFile(){
            StreamReader reader = new StreamReader("br-dictionary.txt");
            string data = reader.ReadToEnd();
            string[] words = data.Split("\n");
            int length_dict = words.Length;
            int count_a = 0;

            string[] dict = new string[27];
            
            for (int i = 0; i < length_dict; i++) {
                char[] word_broken = words[i].ToCharArray();
                if (word_broken[0] == 'a'){
                    continue;
                }
                else if (word_broken[0] == 'b'){
                    continue;
                }
                else if (word_broken[0] == 'c'){
                    continue;
                }
                else if (word_broken[0] == 'd'){
                    continue;
                }
                else if (word_broken[0] == 'e'){
                    continue;
                }
                else if (word_broken[0] == 'f'){
                    continue;
                }
                else if (word_broken[0] == 'g'){
                    continue;
                }
                else if (word_broken[0] == 'h'){
                    continue;
                }
                else if (word_broken[0] == 'i'){
                    continue;
                }
                else if (word_broken[0] == 'j'){
                    continue;
                }
                else if (word_broken[0] == 'k'){
                    continue;
                }
                else if (word_broken[0] == 'l'){
                    continue;
                }
                else if (word_broken[0] == 'm'){
                    continue;
                }
                else if (word_broken[0] == 'n'){
                    continue;
                }
                else if (word_broken[0] == 'o'){
                    continue;
                }
                else if (word_broken[0] == 'p'){
                    continue;
                }
                else if (word_broken[0] == 'q'){
                    continue;
                }
                else if (word_broken[0] == 'r'){
                    continue;
                }
                else if (word_broken[0] == 's'){
                    continue;
                }
                else if (word_broken[0] == 't'){
                    continue;
                }
                else if (word_broken[0] == 'u'){
                    continue;
                }
                else if (word_broken[0] == 'v'){
                    continue;
                }
                else if (word_broken[0] == 'w'){
                    continue;
                }
                else if (word_broken[0] == 'x'){
                    continue;
                }
                else if (word_broken[0] == 'y'){
                    continue;
                }
                else if (word_broken[0] == 'z'){
                    continue;
                }
            }
        }
    }    
}