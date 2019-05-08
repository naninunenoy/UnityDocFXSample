using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyPlugin2 {
    /// <summary>
    /// アセンブリごとでなくnamespaceごとに作られる
    /// </summary>
    public class FugaDataInOtherNameSpace {
        public int Number { set; get; }
        public string Message { set; get; }
    }
    namespace NestedNameSpace {
        /// <summary>
        /// ネストしたnamespaceはどう表示されるか
        /// </summary>
        public class FugaDataInNestedNameSpace {
            public int Number { set; get; }
            public string Message { set; get; }
        }
    }
}
