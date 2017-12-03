using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSEReader
{
    class MerResult
    {
        public int CodActa { get; set; }
        public int NumNivel { get; set; }
        public string NomNivel { get; set; }
        public string CodMER { get; set; }
        public byte CodDepartamento { get; set; }
        public short CodMunicipio { get; set; }
        public string NomDepartamento { get; set; }
        public string NomMunicipio { get; set; }
        public string NomCentroVotacion { get; set; }
        public string NomEstado { get; set; }
        public short NumVotosValidos { get; set; }
        public short NumVotosBlancos { get; set; }
        public short NumVotosNulos { get; set; }
        public short NumVotosTotal { get; set; }
        public short NumPapeletasRecibidas { get; set; }
        public short NumPapeletasSobrantes { get; set; }
        public short NumPapeletasUtilizadas { get; set; }
        public int? CodBarra { get; set; }
        public string Url { get; set; }
        public bool ImageAvailable { get; set; }
        public List<Votos> Votos { get; set; }
    }

    public class Votos
    {
        public short CodCandidato { get; set; }
        public string NomCandidato { get; set; }
        public string IdentidadCandidato { get; set; }
        public short CodPartido { get; set; }
        public string NomPartido { get; set; }
        public short NumVotos { get; set; }
        public short NumPosicion { get; set; }
        public short NumPosicionActa { get; set; }
    }
}