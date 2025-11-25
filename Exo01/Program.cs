/*
 * En utilisant la méthode « Console.ReadLine() »
 * ◼ Demander à l’utilisateur d’encoder 2 nombres (int) et d’en faire l’addition, 
 *  la conversion devra utiliser la méthode « int.Parse() »
 * ◼ Demander à l’utilisateur d’encoder 2 nombres (int) et d’en faire l’addition, 
 *  la conversion devra utiliser la méthode « int.TryParse() »
 */



// 1.  Méthode Parse()

Console.WriteLine($"Encodez le premier nombre :");
int nb1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Encodez le deuxième nombre :");
int nb2 = int.Parse(Console.ReadLine());

Console.WriteLine($"{nb1} + {nb2} = {nb1 + nb2}");


// 2.  Méthode TryParse()

Console.WriteLine($"Encodez le premier nombre :");
int.TryParse(Console.ReadLine(), out nb1);

Console.WriteLine($"Encodez le deuxième nombre :");
int.TryParse(Console.ReadLine(), out nb2);

Console.WriteLine($"{nb1} + {nb2} = {nb1 + nb2}");
