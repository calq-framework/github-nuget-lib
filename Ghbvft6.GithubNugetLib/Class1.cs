using System;

namespace Ghbvft6.GithubNugetLib
{
    class SomeException : Exception {
        public SomeException(string? message) : base(message) {
        }
    }
    public class Class1
    {
        public String foo() {
            return "Ghbvft6.GithubNugetLib";
        }
        public String foo2() {
            return "Ghbvft6.GithubNugetLib2";
        }
        public String foo3() {
            return "Ghbvft6.GithubNugetLib3";
        }
        public String foo4() {
            return "Ghbvft6.GithubNugetLib4";
        }
        public String foo5() {
            return "Ghbvft6.GithubNugetLib5";
        }
        public String foo6() {
            return "Ghbvft6.GithubNugetLib6";
        }
        public String fooerror() {
            throw new SomeException("something");
            return "Ghbvft6.GithubNugetLib6";
        }
        public String fooerror2() {
            throw new SomeException("something");
            return "Ghbvft6.GithubNugetLib6";
        }
        public String fooerror3() {
            throw new SomeException("something");
            return "Ghbvft6.GithubNugetLib6";
        }
        public String fooerror4() {
            throw new SomeException("something");
            return "Ghbvft6.GithubNugetLib6";
        }
        public String fooerror5() {
            throw new SomeException("something");
            return "Ghbvft6.GithubNugetLib6";
        }
    }
}
