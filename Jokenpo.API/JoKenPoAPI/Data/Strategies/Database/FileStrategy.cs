using Jokenpo.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JoKenPoAPI.Data.Strategies.Database
{
    public class FileStrategy : IJogo
    {
        string _filePath = "jogo.txt";

        public bool Post()
        {
            using (var writeFileConfig = new StreamWriter(_filePath, append: true))
            {
                string putJogo = "Jogador1: Paulo; Jogador2: Joao, DataInicio: 22/01/2019; Resultado: Vitoria Jogador1; JogadaJogador1: Pedra; JogadaJogador2: Tesoura; Status: ATIVO;";
                writeFileConfig.WriteLine(putJogo);
                return true;
            }
        }

        public bool Put()
        {
            string editedFuncionarioFile = "Jogador1: Paulo; Jogador2: Juca, DataInicio: 22/01/2019; Resultado: Vitoria Jogador1; JogadaJogador1: Pedra; JogadaJogador2: Tesoura; Status: ATIVO;";
            string[] arrLine = File.ReadAllLines(_filePath);
            arrLine[0] = editedFuncionarioFile;
            File.WriteAllLines(_filePath, arrLine);
            return true;
        }

        public bool Delete()
        {
            string deleteFromFile = "Jogador1: Paulo; Jogador2: Juca, DataInicio: 22/01/2019; Resultado: Vitoria Jogador1; JogadaJogador1: Pedra; JogadaJogador2: Tesoura; Status: ATIVO;";
            var tempFile = Path.GetTempFileName();
            var linesToKeep = File.ReadLines(_filePath).Where(l => l != deleteFromFile);

            File.WriteAllLines(tempFile, linesToKeep);

            File.Delete(_filePath);
            File.Move(tempFile, _filePath);
            return true;
        }


        public List<Jogo> Get(string pathConfigFile)
        {
            List<Jogo> lstJogo = new List<Jogo>();
            DateTime dateResult = new DateTime();
            var culture = CultureInfo.CreateSpecificCulture("en-US");
            var style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;
            double salario = new double();
            var configInformation = new List<string>();
            using (var readerFileConfig = new StreamReader(pathConfigFile))
                while (readerFileConfig.Peek() >= 0)
                    configInformation.Add(readerFileConfig.ReadLine());

            for (int i = 1; i < configInformation.Count; i++)
            {
                var arrayFuncionario = configInformation[i].Split(';').ToList();
                Jogo jogo = new Jogo();
                jogo.Jogador1 = arrayFuncionario[0].ToString();
                jogo.Jogador2 = arrayFuncionario[1].ToString();
                if (DateTime.TryParse(arrayFuncionario[2].ToString(), out dateResult))
                    jogo.DataInicio = dateResult;
                jogo.Resultado = arrayFuncionario[3].ToString();
                jogo.JogadaJogador1 = arrayFuncionario[4].ToString();
                jogo.JogadaJogador2 = arrayFuncionario[5].ToString();
                jogo.Status = arrayFuncionario[6].ToString();

                lstJogo.Add(jogo);
            }

            return lstJogo;
        }
    }
}
