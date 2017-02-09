﻿// Copyright 2017 Brian Allred
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.

namespace NYoutubeDL.Options
{
    #region Using

    using Helpers;

    #endregion

    /// <summary>
    ///     Object containing Authentication parameters
    /// </summary>
    public class Authentication : OptionSection
    {
        [Option] private readonly BoolOption netRc = new BoolOption("-n");
        [Option] private readonly StringOption password = new StringOption("-p");
        [Option] private readonly StringOption twoFactor = new StringOption("-2");
        [Option] private readonly StringOption username = new StringOption("-u");
        [Option] private readonly StringOption videoPassword = new StringOption("--video-password");

        /// <summary>
        ///     -n
        /// </summary>
        public bool NetRc
        {
            get { return this.netRc.Value ?? false; }
            set { this.netRc.Value = value; }
        }

        /// <summary>
        ///     -p
        /// </summary>
        public string Password
        {
            get { return this.password.Value; }
            set { this.password.Value = value; }
        }

        /// <summary>
        ///     -2
        /// </summary>
        public string TwoFactor
        {
            get { return this.twoFactor.Value; }
            set { this.twoFactor.Value = value; }
        }

        /// <summary>
        ///     -u
        /// </summary>
        public string Username
        {
            get { return this.username.Value; }
            set { this.username.Value = value; }
        }

        /// <summary>
        ///     --video-password
        /// </summary>
        public string VideoPassword
        {
            get { return this.videoPassword.Value; }
            set { this.videoPassword.Value = value; }
        }
    }
}