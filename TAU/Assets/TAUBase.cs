using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TAU
{
    public class TAUBase : MonoBehaviour
    {
        /*
         * TAU is a Unity singleton
         * ONLY ONE INSTANCE AT A TIME!
         */
        public static TAUBase m_instance;
        public static TAUBase Instance
        {
            get
            {
                if (!m_instance)
                {
                    var tauGO = new GameObject("TAU");
                    m_instance = tauGO.AddComponent<TAUBase>();
                    DontDestroyOnLoad(tauGO);
                }
                return m_instance;
            }
        }

        private void OnEnable()
        {
            //Prepare threads
        }

        private void OnDisable()
        {
            //Close threads
        }

        private void Update()
        {
            //Run TAUUpdate
        }

        private void FixedUpdate()
        {
            //Run TAUFixedUpdate
        }
    }
}
