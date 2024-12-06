using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Forêt_des_Ombres
{
    internal class GestionMusique
    {

        private static SoundPlayer soundPlayer;

        public static void StartBackgroundMusic()
        {
            soundPlayer = new SoundPlayer("Images/MusiqueJeu.wav");

            soundPlayer.PlayLooping();
        }

        public static void StopBackgroundMusic()
        {
            if (soundPlayer != null)
            {
                soundPlayer.Stop();
            }
        }
    }
}
