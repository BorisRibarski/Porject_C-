    class Program {
    static void Main() {
        Node a = new ValueNode();
        Node b = new ValueNode();
        Node ab = new OrNode(a,b);
        Node c = new ValueNode();
        Node ac = new AndNode(ab, c);
        Node d = new ValueNode();
        Node ad = new OrNode(ac, d);
        Function func = new Function(ad);
        //Console.WriteLine(ab.calculate([true, false]));
        // Console.WriteLine(ac.calculate([true, false, true]));
        Console.WriteLine(func.calculate([true, false, false, true]));
        Console.WriteLine(ad.print());
    }
}
