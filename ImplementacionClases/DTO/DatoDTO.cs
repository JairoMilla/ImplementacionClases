using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionClases.DTO
{
    public class DatoDTO
    {
        private int id;
        private float flujo;
        private float nivel;
        private float temperatura;
        private float voltaje;
        private BancoDTO banco;
        private CeldaDTO celda;

        public int Id { get => id; set => id = value; }
        public float Flujo { get => flujo; set => flujo = value; }
        public float Nivel { get => nivel; set => nivel = value; }
        public float Temperatura { get => temperatura; set => temperatura = value; }
        public float Voltaje { get => voltaje; set => voltaje = value; }
        public float TemperaturaFarenheit { get => temperatura * (9/5) + 32;}

    }
    public class CeldaDTO
    {
        private int id;
        private int numero;

        public int Id { get => id; set => id = value; }
        public int Numero { get => numero; set => numero = value; }
    }
    public class BancoDTO
    {
        private int id;
        private int numero;
        private CeldaDTO[] celdas;

        public int Id { get => id; set => id = value; }
        public int Numero { get => numero; set => numero = value; }
        public CeldaDTO[] Celdas { get => celdas; set => celdas = value; }

        public BancoDTO()
        {
            this.celdas = new CeldaDTO[] { };//Inicializar un arreglo de objetos vacios del tipoCeldaDTO
        }

        public BancoDTO(int id, int numero, CeldaDTO[] celdas)
        {
            this.celdas = new CeldaDTO[] {};
            this.id = id;
            this.numero = numero;
            this.celdas = celdas;
        }
    }
}
