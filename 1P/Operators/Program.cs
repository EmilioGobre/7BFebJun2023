#region Unary Operators
    int a = 3;
    WriteLine($" a starts on {a}");
    a++;
    int b = a++;
    ++a;
    WriteLine($"a is {a} b is {b}");
#endregion

#region Binary Operators
    int c = 1;
    int d = 4;
    WriteLine($"c + d = {c + d}");
    WriteLine($"c - d = {c - d}");
    WriteLine($"c * d = {c * d}");
    WriteLine($"c / d = {c / d}");
    WriteLine($"c % d = {c % d}");
#endregion

#region Assigment Operators
    int p = 6;
    p += 5;
    p -= 2;
    p *= 4;
    p /= 3;
#endregion

#region Logical Operators
    bool l = true;
    bool m = false;
    WriteLine($"AND |l           |m  ");
    WriteLine($"l   |{l & l, -5} | {l & m, -5}");
    WriteLine($"m   |{m & l, -5} | {m & m, -5}");

    // OR Logic
    WriteLine($"OR |l           |m  ");
    WriteLine($"l   |{l | l, -5} | {l | m, -5}");
    WriteLine($"m   |{m | l, -5} | {m | m, -5}");

    // XOR
    WriteLine($"XOR |l           |m  ");
    WriteLine($"l   |{l ^ l, -5} | {l ^ m, -5}");
    WriteLine($"m   |{m ^ l, -5} | {m ^ m, -5}");
#endregion

#region Conditional Operators
List<int> list = new();
    if (!l && ( a == 3 || !m) && list.Count >=0)
    {

    }
#endregion

#region Ternary Operator
    int z =  7 + 1 == 9 ? z = 9 : z = 8;
    bool zz = 7 + 1 == 9 ? true : false;
    bool zzz = a != b ? true : false;
    int zzz2 = a != b ?  a : b;
#endregion