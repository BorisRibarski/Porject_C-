class Function{
    Node head;

    public Function(Node node){
        this.head = node;
    }

    public bool calculate(bool[] args){
        string str = head.print();
        string[] tokens = StringService.Split(str, ' ');
        bool result = args[0];
        for(int i = 0;i < tokens.Length/2;i++){
            bool next = args[i+1];
            switch(tokens[i*2+1]){
                case "|":
                    Console.WriteLine(result + "|" + next);
                    result = result || next;
                    break;
                case "&":
                    Console.WriteLine(result + "&" + next);
                    result = result && next;
                    break;
                default:
                    Console.WriteLine("error");
                    result = false;
                    break;
            }
        }
        return result;
    }
}