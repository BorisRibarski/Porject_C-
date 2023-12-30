abstract class Node {
    public abstract bool calculate(bool[] args);
    public abstract string print();
}

class OpositeNode : Node {
    Node next;
    public OpositeNode(Node next) {
        this.next = next;
    }

    public override bool calculate(bool[] args) {
        return !next.calculate(ArrayService.removeFirstBool(args));
    }

    public override string print() {
        return "!" + next.print();
    }
}

class AndNode : Node {
    Node NextA;
    Node nextB;

    public AndNode(Node next1, Node next2) {
        this.NextA = next1;
        this.nextB = next2;
    }

    public override bool calculate(bool[] args) {
        return NextA.calculate(args) && nextB.calculate(ArrayService.removeFirstBool(args));
    }

    public override string print() {
        return NextA.print() + " & " + nextB.print();
    }
}

class OrNode : Node {
    Node NextA;
    Node nextB;

    public OrNode(Node next1, Node next2) {
        this.NextA = next1;
        this.nextB = next2;
    }

    public override bool calculate(bool[] args) {
        return NextA.calculate(args) || nextB.calculate(ArrayService.removeFirstBool(args));
    }

    public override string print() {
        return NextA.print() + " | " + nextB.print();
    }
}

class ValueNode : Node {
    public override bool calculate(bool[] args) {
        return args[0];
    }

    public override string print() {
        return "v";
    }
}