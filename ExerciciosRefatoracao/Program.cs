// See https://aka.ms/new-console-template for more information

using ExerciciosRefatoracao.Repository;
using ExerciciosRefatoracao.UI;


TelaPrincipal principal = new TelaPrincipal(new ClienteRepository(), ConsoleColor.Green);

principal.Load();