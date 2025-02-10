using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.Localization;
using UnityEngine;

namespace IntroCutscene
{
    public class IntroSequence : MonoBehaviour
    {
        public string nextScene = "Campaign";
        public UnityEngine.Animator animator;
        public LocalizedString[] textKeys;

        private int textCurrent;
        private GameObject current;

        private void Start()
        {
            if (!GameManager.Ready)
                return;
            Transition.End();
            this.StartSequence();
        }

        private void OnDisable()
        {
            CinemaBarSystem.Clear();
            CinemaBarSystem.OutInstant();
        }

        private void StartSequence()
        {
            CinemaBarSystem.InInstant();
            CinemaBarSystem.Clear();
            this.animator.SetTrigger("Play");
        }

        private void EndSequence()
        {
            Routine routine = new Routine(Transition.To(this.nextScene));
        }

        private void NextText()
        {
            CinemaBarSystem.SetScript(this.textKeys[this.textCurrent++].GetLocalizedString(), true);
        }
    }
}
