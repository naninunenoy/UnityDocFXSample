using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyPlugin;

namespace docfxSample {
    /// <summary>
    /// Hoge component.
    /// </summary>
    public class HogeComponent : MonoBehaviour {
        /// <summary>
        /// The fuga data.
        /// </summary>
        FugaData fugaData;
        /// <summary>
        /// Gets the type of the piyo.
        /// </summary>
        /// <value>The type of the piyo.</value>
        public PiyoType PiyoType { private set; get; }

        /// <summary>
        /// Init the specified fuga and piyo.
        /// </summary>
        /// <param name="fuga">Fuga.</param>
        /// <param name="piyo">Piyo.</param>
        public void Init(FugaData fuga, PiyoType piyo) {
            fugaData = fuga;
            PiyoType = piyo;
        }
        /// <summary>
        /// Start is called before the first frame update
        /// </summary>
        public void Start() {

        }

        /// <summary>
        /// Update is called once per frame
        /// </summary>
        public void Update() {

        }
    }
}
