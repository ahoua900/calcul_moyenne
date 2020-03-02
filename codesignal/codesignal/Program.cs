using System;
using System.Collections.Generic;

namespace codesignal
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                IDictionary<string, int> dico = new Dictionary<string, int>();
                try
                {
                    List<int> list = new List<int>();
                    List<int> liste = new List<int>();
                    
                    var moyenneGenerale = 0;
                    var totalNotes = 0;
                    var totalCoef = 0;
                    Console.WriteLine("vous avez combien de matieres ?");
                    var nombre = Console.ReadLine();
                    var NombreDeMatiere = Convert.ToInt32(nombre);

                    Console.WriteLine("entrer votre NOM:");
                    var name = Console.ReadLine();
                    for (int i = 0; i < NombreDeMatiere; i++)

                        {
                        
                        Console.WriteLine("entrer votre matiere");
                            var matiere = Console.ReadLine();
                        Console.WriteLine("entrer le coefficient de votre matiere");
                            var coef = Console.ReadLine();
                            var coeff = Convert.ToInt32(coef);
                        Console.WriteLine("entrer votre moyenne de " + matiere);
                            var mat = Console.ReadLine();
                            var note = Convert.ToInt32(mat);
                            var generale = 20;
                        

                            if (note <= 20)
                            {
                                Console.WriteLine("votre moyenne en " + matiere + " " + "est de " + " " + (note*coeff) + "/"+ (coeff*generale) );
                                list.Add(note*coeff);
                                liste.Add(coeff);
                                
                            
                            }
                            else
                            {
                                Console.WriteLine("votre moyenne doit etre comprise en 00 et 20");
                                continue;
                            }


                        foreach (var a in list)
                        {
                            totalNotes += a;
                            break;
                            
                        }
                        foreach (var b in liste)
                        {
                            totalCoef += b;
                            break;

                        }
                        moyenneGenerale = (totalNotes / totalCoef);

                        
                        
                    }
                       dico.Add(name, moyenneGenerale);
                    Console.WriteLine("la somme de vos notes est " + totalNotes);
                    Console.WriteLine("Votre moyenne generale est de" + " " + moyenneGenerale + "/20");
                    if (moyenneGenerale >=0 && moyenneGenerale<=10 )
                    {
                        Console.WriteLine("votre niveau est PASSABLE remettez vous au travail");
                    }
                    else if (moyenneGenerale >= 10 && moyenneGenerale <= 14)
                    {
                        Console.WriteLine("Votre niveau est BON continuez ainsi");
                    }
                    else
                    {
                        Console.WriteLine("Vous avez un TRES BON  niveau ne baissez plus les bras ");
                    }

                    
                }
                catch
                {
                    Console.WriteLine("Vous n'avez pas entré un entier ex: 13");

                }
                foreach (var item in dico)
                {
                    Console.WriteLine("l'eleve {0} : a comme moyenne de {1}/20", item.Key, item.Value);
                }
            }
        }
            

    
    }
}
