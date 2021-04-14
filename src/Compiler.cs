using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBSL
{
    /**
     * A factory for converting SBSL into a runnable program
     */
    class Compiler
    {
        private string program_src;
        private string compilation_log;
        private bool compilation_success;
        /**
         * Main compiler entry point, returns a runnable program object
         * @note  The actual usage is likely to change
         */
        public static Program compile(string src){
            Compiler c = new Compiler(src);
            // Check for errors
            // Return error log
            // else Program
            return new Program();  // @todo
        }
        private Compiler(string src)
        {
            program_src = src;
            compilation_log = "";
            compilation_success = LexicalAnalysis()
                && SyntaxAnalysis()
                && SemanticAnalysis()
                && GenerateIntermediateCode();
        }
        /**
         * @return True on compilation success
         * @see getLog() can be called to get a compilation log on failure
         */
        public bool getSuccess()
        {
            return compilation_success;
        }
        /**
         * Returns any messages from the compilation process
         */
        public string getLog()
        {
            return compilation_log;
        }
        /**
         * Stage 1: Convert the character stream into a token stream
         * @return True if the stage detects no errors
         */
        private bool LexicalAnalysis()
        {
            // @todo
            return true;
        }
        /**
         * Stage 2: Convert the token stream into an abstract syntax tree
         * @return True if the stage detects no errors
         */
        private bool SyntaxAnalysis()
        {
            // @todo
            return true;
        }
        /**
         * Stage 3: Optimise the syntax tree?
         * @return True if the stage detects no errors
         */
        private bool SemanticAnalysis()
        {
            // @todo
            return true;
        }
        /**
         * Stage 4: Convert that syntax tree into an intermediate format we can execute
         * @return True if the stage detects no errors
         * @note We might simply execute the syntax tree directly, so this might not be required
         */
        private bool GenerateIntermediateCode()
        {
            // @todo
            return true;
        }
    }
}
