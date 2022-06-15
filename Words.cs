using dictionary;

namespace words{
    public class Words{
        public static void ReadFile(){
            StreamReader reader = new StreamReader("br-dictionary.txt");
            string data = reader.ReadToEnd();
            string[] words = data.Split("\n");
            int length_dict = words.Length;
            
            string[] dict = new string[27];
            
            for (int i = 0; i < length_dict; i++) {
                char[] word_broken = words[i].ToCharArray();
                int length_word = word_broken.Length;

                if (word_broken[0] == 'a'){
                    Hashtable_a.AddAWords(words[i], length_word);
                }
                else if (word_broken[0] == 'b'){
                    Hashtable_b.AddAWords(words[i], length_word);
                }
                else if (word_broken[0] == 'c'){
                    Hashtable_c.AddAWords(words[i], length_word);
                }
                else if (word_broken[0] == 'd'){
                    Hashtable_d.AddAWords(words[i], length_word);
                }
                else if (word_broken[0] == 'e'){
                    Hashtable_e.AddAWords(words[i], length_word);
                }
                else if (word_broken[0] == 'f'){
                    Hashtable_f.AddAWords(words[i], length_word);
                }
                else if (word_broken[0] == 'g'){
                    Hashtable_g.AddAWords(words[i], length_word);
                }
                else if (word_broken[0] == 'h'){
                    Hashtable_h.AddAWords(words[i], length_word);
                }
                else if (word_broken[0] == 'i'){
                    Hashtable_i.AddAWords(words[i], length_word);
                }
                else if (word_broken[0] == 'j'){
                    Hashtable_j.AddAWords(words[i], length_word);
                }
                else if (word_broken[0] == 'k'){
                    Hashtable_k.AddAWords(words[i], length_word);
                }
                else if (word_broken[0] == 'l'){
                    Hashtable_l.AddAWords(words[i], length_word);
                }
                else if (word_broken[0] == 'm'){
                    Hashtable_m.AddAWords(words[i], length_word);
                }
                else if (word_broken[0] == 'n'){
                    Hashtable_n.AddAWords(words[i], length_word);
                }
                else if (word_broken[0] == 'o'){
                    Hashtable_o.AddAWords(words[i], length_word);
                }
                else if (word_broken[0] == 'p'){
                    Hashtable_p.AddAWords(words[i], length_word);
                }
                else if (word_broken[0] == 'q'){
                    Hashtable_q.AddAWords(words[i], length_word);
                }
                else if (word_broken[0] == 'r'){
                    Hashtable_r.AddAWords(words[i], length_word);
                }
                else if (word_broken[0] == 's'){
                    Hashtable_s.AddAWords(words[i], length_word);
                }
                else if (word_broken[0] == 't'){
                    Hashtable_t.AddAWords(words[i], length_word);
                }
                else if (word_broken[0] == 'u'){
                    Hashtable_u.AddAWords(words[i], length_word);
                }
                else if (word_broken[0] == 'v'){
                    Hashtable_v.AddAWords(words[i], length_word);
                }
                else if (word_broken[0] == 'w'){
                    Hashtable_w.AddAWords(words[i], length_word);;
                }
                else if (word_broken[0] == 'x'){
                    Hashtable_x.AddAWords(words[i], length_word);;
                }
                else if (word_broken[0] == 'y'){
                    Hashtable_y.AddAWords(words[i], length_word);;
                }
                else if (word_broken[0] == 'z'){
                    Hashtable_z.AddAWords(words[i], length_word);;
                }
            }
        }
    }    
}