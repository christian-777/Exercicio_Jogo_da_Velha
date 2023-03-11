internal class Program
{
    private static void Main(string[] args)
    {
        int[,] velha = new int[3, 3];
        int l=0, c=0, esc;
        char jogador;
        bool certo;
        int i;
        string aux;

        for(i = 0; i < 9; i++)
        {
            Console.Clear();
            exibir(velha);
            if (i % 2 == 0)
            {
                jogador = 'X';
            }
            else
            {
                jogador = 'O';
            }

            Console.WriteLine("digite onde deseja jogar jogador \""+jogador+"\""+": ");
            aux=Console.ReadLine();

            if (!int.TryParse(aux, out esc))
            {
                i--;
                Console.WriteLine("posicao invalida");
                Console.ReadKey();
                continue;
            }

            certo = true;

            switch (esc)
            {
                case 1:
                    l = 0;
                    c = 0;
                    break;

                case 2:
                    l = 0;
                    c = 1;
                    break;

                case 3:
                    l = 0;
                    c = 2;
                    break;

                case 4:
                    l = 1;
                    c = 0;
                    break;

                case 5:
                    l = 1;
                    c = 1;
                    break;

                case 6:
                    l = 1;
                    c = 2;
                    break;

                case 7:
                    l = 2;
                    c = 0;
                    break;

                case 8:
                    l = 2;
                    c = 1;
                    break;

                case 9:
                    l = 2;
                    c = 2;
                    break;

                default:
                    certo = false;
                    Console.WriteLine("posição invalida");
                    i--;
                    Console.ReadKey();
                    break;
            }

            if (certo)
            {
                if (velha[l, c] == 0)
                {
                    if (i % 2 == 0)
                    {
                        velha[l, c] = 1;
                    }
                    else
                    {
                        velha[l, c] = 2;
                    }
          
                    if (i >= 4)
                    {
                        if (VenceuHorizontal(velha) || VenceuVertical(velha) || VenceuDiagonalPrincial(velha) || VenceuDiagonalSecundaria(velha))
                        {
                            Console.Clear();
                            Console.WriteLine("o jogador \""+jogador+"\""+" ganhou");
                          
                            exibir(velha);
                            break;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("nao eh permitido sobregravar");
                    Console.ReadKey();
                    i--;
                }
            }
            
        }
        if (i == 9)
        {
            Console.WriteLine("a velha venceu");
        }
        Console.ReadKey();

        void exibir(int[,] velha)
        {
            Console.WriteLine();
            int i = 1;
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    if (velha[j, k] == 1)
                    {
                        Console.Write("X ");
                    }
                    else if (velha[j, k] == 2)
                    {
                        Console.Write("O ");
                    }
                    else
                    {
                        Console.Write(i+" ");
                    }
                    i++;
                }
                Console.WriteLine("");
            }
            Console.WriteLine();
        }

        bool VenceuHorizontal(int[,] velha)
        {
            int valida, igual=0;

            for(int l = 0; l < 3; l++)
            {
                valida = 0;
                for(int c = 0; c < 3; c++)
                {
                    if (velha[l, c] != 0)
                    {
                        if (valida == 0)
                        {
                            igual = velha[l, c];
                            valida++;
                        }
                        else
                        {
                            if (velha[l, c] == igual)
                            {
                                valida++;
                                igual = velha[l, c];
                            }
                        }
                    }
                }

                if(valida == 3)
                {
                    return true;
                }
            }

            return false;
        }


        bool VenceuVertical(int[,] velha)
        {
            int valida, igual = 0;

            for (int c = 0; c < 3; c++)
            {
                valida = 0;
                for (int l = 0; l < 3; l++)
                {
                    if (velha[l, c] != 0)
                    {
                        if (valida == 0)
                        {
                            igual = velha[l, c];
                            valida++;
                        }
                        else
                        {
                            if (velha[l, c] == igual)
                            {
                                valida++;
                                igual = velha[l, c];
                            }
                        }
                    }
                }

                if (valida == 3)
                {
                    return true;
                }
            }

            return false;
        }



        bool VenceuDiagonalPrincial(int[,] velha)
        {
            int valida=0, igual = 0;

            for (int l = 0; l < 3; l++)
            {

                if (velha[l, l] != 0)
                {
                    if (l == 0)
                    {
                        igual = velha[l, l];
                        valida++;
                    }
                    else
                    {
                        if (velha[l, l] == igual)
                        {
                            valida++;
                            igual = velha[l, l];
                        }
                    }
                }

                if (valida == 3)
                {
                    return true;
                }
            }

            return false;
        }


        bool VenceuDiagonalSecundaria(int[,] velha)
        {
            int valida = 0, igual = 0;

            for (int l = 0; l < 3; l++)
            {

                if (velha[l, 2-l] != 0)
                {
                    if (l == 0)
                    {
                        igual = velha[l, 2-l];
                        valida++;
                    }
                    else
                    {
                        if (velha[l, 2-l] == igual)
                        {
                            valida++;
                            igual = velha[l, 2-l];
                        }
                    }
                }

                if (valida == 3)
                {
                    return true;
                }
            }

            return false;
        }
    }
}