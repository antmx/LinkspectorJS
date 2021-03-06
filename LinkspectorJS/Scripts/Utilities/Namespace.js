﻿
/// <summary>Utility for creating objects that can act like C# Namespaces</summary>
Namespace = function () {

};


Namespace.prototype = {

    /// <summary>Creates a namespace from the given string</summary>
    Create: function(ns) {
        var n, o;
        n = ns.split('.');
        o = window[n[0]] = window[n[0]] || {};
        var l = n.length;
        for (var i = 1; i < l; i++) {
            o = o[n[i]] = o[n[i]] || {};
        }

        if (typeof o !== "object") {
            throw new Error(ns + " not found");
        }

        return o;
    }
};

// Auto-invoked function to bind an instance of Namespace to window for global access
(function() {
    window.Namespace = new Namespace();
})();
