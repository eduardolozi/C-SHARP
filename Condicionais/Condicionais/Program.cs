//-------------------------------------------------------------------------------------------------------------------------------------
//~~~~~~~~~~CONDICIONAIS~~~~~~~~~~
int i = 1;
    int[] vetor = new int[5];
    vetor[0] = 1;    
    vetor[1] = 2;
    vetor[2] = 3;
    vetor[3] = 4;   
    vetor[4] = 5;

    string teste = (i == 1 ? "O numero é 1" : "O numero não é 1");
    Console.WriteLine(teste);
    //o resto é literalmente igual a C
//-------------------------------------------------------------------------------------------------------------------------------------
//.....................................................................................................................................
//.....................................................................................................................................
//-------------------------------------------------------------------------------------------------------------------------------------
//~~~~~~~~~~REPETIÇÕES~~~~~~~~~~
    //while, do while, for, foreach

    //pode ser usado um comando chamado continue que pula para a seguinte iteração sem realizar as proximas linhas dentro do loop
    for (int j = 1; j <= 10; j++) Console.WriteLine(j);

    Console.WriteLine("-------------------------");
    
    //o foreach percorre um array
    foreach(int a in vetor) Console.WriteLine(a);

//-------------------------------------------------------------------------------------------------------------------------------------
//.....................................................................................................................................
//.....................................................................................................................................
//-------------------------------------------------------------------------------------------------------------------------------------
//~~~~~~~~~~ARRAYS E COLLECTIONS~~~~~~~~~~
    string[] Nomes = new string[3];
    Nomes[0] = "BUBALU";
    if(Array.Exists(Nomes, e => e == "BUBALU"))
    {
        Console.WriteLine("-------------------------");
        Console.WriteLine("Nome existe");
    }

    List<string> Alunos = new List<string>();
    Alunos.Add("Eduardo Lozano");
    Alunos.Add("Juan Alejandro");
    Alunos.Remove("Eduardo Lozano");
    Alunos.Add("Icaro");
    Alunos.Add("Eduardo Lozano");
    Alunos.Sort();
    Console.WriteLine("-------------------------");

    //Para procurar por um elemento podemos usar exists
    bool valor = Alunos.Exists(e => e == "Eduardo Lozano");
    string resposta = (valor == true ? "O aluno existe" : "O aluno não existe");
    Console.WriteLine(resposta);

    //Para procurar por uma parte de um elemento podemos usar Find e Contains
    //Console.WriteLine(Alunos.Find(s => s.Contains("Juan")));
    string verificaNome = Alunos.Find(s => s.Contains("Luis"));
    if (verificaNome != null) Console.WriteLine("Existe um aluno com o nome "+ verificaNome);
    else Console.WriteLine("Não existe aluno com esse nome");

    //Para encontrar o indice de um elemento podemos usar o IndexOf, que possui tres formas de implentação
    //Proucrando pela lista toda:
    Console.WriteLine("Index do eduardo: " + Alunos.IndexOf("Eduardo Lozano"));
    //Procurando a partir de um indice:
    Console.WriteLine("Index do Icaro: " + Alunos.IndexOf("Icaro", 1));
    //Procurando em um intervalo:
    Console.WriteLine("Index do Alejandro: " + Alunos.IndexOf("Juan Alejandro", 0, 1));

    Console.WriteLine("Indice do aluno Icaro: " + Alunos.BinarySearch("Icaro")); //para realizar a pesquisa binaria primeiro precisamos ordenar a lista
    Console.WriteLine("Tamanho da lista: " + Alunos.Count);

    Console.WriteLine("-------------------------");
    foreach (string l in Alunos) Console.WriteLine(l);
//-------------------------------------------------------------------------------------------------------------------------------------
//.....................................................................................................................................
//.....................................................................................................................................
//-------------------------------------------------------------------------------------------------------------------------------------