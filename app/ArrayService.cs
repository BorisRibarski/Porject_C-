class ArrayService {
    public static bool[] removeFirstBool(bool[] values){
        bool[] ret = new bool[values.Length-1];
        for(int i = 1;i < values.Length;i++){
            ret[i-1] = values[i];
        }
        return ret;
    }
}