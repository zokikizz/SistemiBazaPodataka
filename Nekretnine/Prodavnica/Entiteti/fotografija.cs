using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemiBazaPodataka.Entiteti
{



    public class fotografija
    {
        public virtual int Id {get; protected set;}
        public virtual Byte[] foto { get; set; }
        public virtual nekretnina Pripada { get; set; }


        public static byte[] ConvertImgToByte(Image i)
        {
            ImageConverter con = new ImageConverter();
            return (byte[])con.ConvertTo(i, typeof(byte[]));
        }

    }
}
