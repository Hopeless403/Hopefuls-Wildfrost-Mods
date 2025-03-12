using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;

namespace WildfrostHopeMod.Leader_Colour_Test
{
    /// <summary>
    /// Huge credits to Björn Ottosson at https://bottosson.github.io/posts/oklab/
    /// </summary>
    public class OKLabHelpers
    {
        /// <summary>
        /// L – perceived lightness, 
        /// a – how green/red the color is, 
        /// b – how blue/yellow the color is
        /// </summary>
        public struct Lab { public float L; public float a; public float b;
            public readonly Color ToColor()
            {
                RGB c = oklab_to_linear_srgb(this);
                return new Color(c.r, c.g, c.b);
            }
        };
        public struct RGB { public float r; public float g; public float b;
            public readonly Color ToColor()
            {
                RGB c = this;
                return new Color(c.r, c.g, c.b);
            }
        };

        public static Lab linear_srgb_to_oklab(RGB c)
        {
            float l = 0.4122214708f * c.r + 0.5363325363f * c.g + 0.0514459929f * c.b;
            float m = 0.2119034982f * c.r + 0.6806995451f * c.g + 0.1073969566f * c.b;
            float s = 0.0883024619f * c.r + 0.2817188376f * c.g + 0.6299787005f * c.b;
            
            float l_ = Mathf.Pow(l, 1/3f);
            float m_ = Mathf.Pow(m, 1/3f);
            float s_ = Mathf.Pow(s, 1/3f);

            return new Lab{
                L = 0.2104542553f * l_ + 0.7936177850f * m_ - 0.0040720468f * s_,
                a = 1.9779984951f * l_ - 2.4285922050f * m_ + 0.4505937099f * s_,
                b = 0.0259040371f * l_ + 0.7827717662f * m_ - 0.8086757660f * s_,
            };
        }

        public static RGB oklab_to_linear_srgb(Lab c)
        {
            float l_ = c.L + 0.3963377774f * c.a + 0.2158037573f * c.b;
            float m_ = c.L - 0.1055613458f * c.a - 0.0638541728f * c.b;
            float s_ = c.L - 0.0894841775f * c.a - 1.2914855480f * c.b;

            float l = l_ * l_ * l_;
            float m = m_ * m_ * m_;
            float s = s_ * s_ * s_;

            return new RGB{
                r = +4.0767416621f * l - 3.3077115913f * m + 0.2309699292f * s,
		        g = -1.2684380046f * l + 2.6097574011f * m - 0.3413193965f * s,
		        b = -0.0041960863f * l - 0.7034186147f * m + 1.7076147010f * s,
            };
        }
    }
}
