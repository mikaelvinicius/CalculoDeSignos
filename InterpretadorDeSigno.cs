using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signo
{
    class InterpretadorDeSigno
    {
        private Signo[] signos = new Signo[12];
        public InterpretadorDeSigno()
        {
            signos[0] = new Signo { diaInicio = 20, mesInicio = 1, diaFim = 18, mesFim = 2, nome = "Aquários", caracteristicas = "Aquarios é..." };
            signos[1] = new Signo { diaInicio = 19, mesInicio = 2, diaFim = 19, mesFim = 3, nome = "Peixes", caracteristicas = "Peixes é..." };
            signos[2] = new Signo { diaInicio = 21, mesInicio = 3, diaFim = 20, mesFim = 4, nome = "Áries", caracteristicas = "Áries é..." };
            signos[3] = new Signo { diaInicio = 20, mesInicio = 4, diaFim = 21, mesFim = 5, nome = "Touro", caracteristicas = "Touro é..." };
            signos[4] = new Signo { diaInicio = 21, mesInicio = 5, diaFim = 22, mesFim = 6, nome = "Gêmeos", caracteristicas = "Gêmeos é..." };
            signos[5] = new Signo { diaInicio = 22, mesInicio = 6, diaFim = 23, mesFim = 7, nome = "Câncer", caracteristicas = "Câncer é..." };
            signos[6] = new Signo { diaInicio = 23, mesInicio = 7, diaFim = 24, mesFim = 8, nome = "Leão", caracteristicas = "Aquarios é..." };
            signos[7] = new Signo { diaInicio = 23, mesInicio = 8, diaFim = 25, mesFim = 9, nome = "Virgem", caracteristicas = "Aquarios é..." };
            signos[8] = new Signo { diaInicio = 23, mesInicio = 9, diaFim = 26, mesFim = 10, nome = "Libra", caracteristicas = "Aquarios é..." };
            signos[9] = new Signo { diaInicio = 23, mesInicio = 10, diaFim = 27, mesFim = 11, nome = "Escorpião", caracteristicas = "Aquarios é..." };
            signos[10] = new Signo { diaInicio = 22, mesInicio = 11, diaFim = 28, mesFim = 12, nome = "Sagitário", caracteristicas = "Aquarios é..." };
            signos[11] = new Signo { diaInicio = 22, mesInicio = 12, diaFim = 29, mesFim = 1, nome = "Capricórnio", caracteristicas = "Aquarios é..." };

        }

        public Signo Interpretar(int dia, int mes)
        {
            Signo signo = null; //Iniciamos o objeto signo, do tipo Signo, como nulo, pois até o momento não sabemos qual signo será retornado
            for (int i = 0; i < signos.Length; i++)
            {
                if ((dia >= signos[i].diaInicio && signos[i].mesInicio == mes) || (dia <= signos[i].diaFim && mes == signos[i].mesFim))
                {
                    signo = signos[i];
                    break;
                }
            }
            return signo; //Todo método que retorne um resultado deve finalizar com a instrução return. O retorno deve ser do mesmo tipo indicado na assinatura do 
        }
    }
}
