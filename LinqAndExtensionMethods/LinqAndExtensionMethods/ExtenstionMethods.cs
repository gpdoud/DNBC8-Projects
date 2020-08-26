using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAndExtensionMethods {
    static class ExtenstionMethods {

        public static string Hello(this int i) {
            return $"Hello number {i}";
        }
    }
}
