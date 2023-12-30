class StringService {
    public static string[] Split(string str, char delimiter){
        int numOfStrings = 0;
        for(int i = 0; i < str.Length;i++){
            if(str[i] == delimiter){
                numOfStrings++;
            }
        }
        numOfStrings++;
        string[] strings = new string[numOfStrings];
        numOfStrings = 0;
        string curr = "";
        str += ' ';
        for(int i = 0; i < str.Length;i++){
            if(str[i] == delimiter){
                strings[numOfStrings] = curr;
                curr = "";
                numOfStrings++;
            } else {
                curr += str[i];
            }
        }
        return strings;
    }
    public static string[] Split(string str){
        return Split(str, ' ');
    }
    public static string charToString(char c){
        string s = "";
        s += c;
        return s;
    }
    public static string removeFirstFunction(string str){
        string[] values = Split(str, ' ');
        string ret = "";
        for(int i = 2;i < values.Length;i++){
            ret += values[i];
        }
        return ret;
    }
    public static string removeFirstSymbol(string str){
        string ret = "";
        for(int i = 1;i < str.Length;i++){
            ret += str[i];
        }
        return ret;
    }
    public static bool parseChar(char c){
        if(c == '1'){
            return true;
        } else return false;
    }
}