﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyPlugin {
    /// <summary>
    /// Fuga data.
    /// </summary>
    public class FugaData {
        /// <summary>
        /// The number.
        /// </summary>
        public int Number;
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        public string Message { set; get; }
        /// <summary>
        /// Initializes a new instance of the <see cref="T:MyPlugin.FugaData"/> class.
        /// </summary>
        /// <param name="number">Number.</param>
        public FugaData(int number) {
            Number = number;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="T:MyPlugin.FugaData"/> class.
        /// </summary>
        /// <param name="msg">Message.</param>
        public FugaData(string msg) {
            Message = msg;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="T:MyPlugin.FugaData"/> class.
        /// </summary>
        /// <param name="number">Number.</param>
        /// <param name="msg">Message.</param>
        public FugaData(int number, string msg) {
            Number = number;
            Message = msg;
        }
        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:MyPlugin.FugaData"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:MyPlugin.FugaData"/>.</returns>
        public override string ToString() {
            return $"{Number} {Message}";
        }
        /// <summary>
        /// ２バイト文字も行けるか
        /// emojiは🤔❓
        /// </summary>
        public void 二バイト文字も行けるか() {
            //
        }
    }
}

/// <summary>
/// namespaceを定義しないとdocFXには無視される
/// </summary>
public class FugaFugaData {
    public int Number { set; get; }
    public string Message { set; get; }
}

namespace FugaFugaNameSpace {
    /// <summary>
    /// アセンブリごとでなくnamespaceごとに作られる
    /// </summary>
    public class FugaFugaDataInNameSpace {
        public int Number { set; get; }
        public string Message { set; get; }
    }
    namespace FugaFugaNestedNameSpace {
        /// <summary>
        /// ネストしたnamespaceはどう表示されるか
        /// </summary>
        public class FugaFugaDataInNestedNameSpace {
            public int Number { set; get; }
            public string Message { set; get; }
        }
    }
}