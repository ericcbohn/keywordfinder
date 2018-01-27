interface Keywords {
    words:Keyword[];
}

interface Keyword {
    word:string;
    occurances:number;
}

// class Keyword {
//     word:string;
//     numOccur:number;

//     constructor(word:string, numOccur:number) {
//         this.word = word;
//         this.numOccur = numOccur;
//     }

//     getWord():string {
//         return this.word;
//     }

//     setWord(word:string):void {
//         this.word = word;
//     }

//     getNumOccur():number {
//         return this.numOccur;
//     }

//     setNumOccur(numOccur:number) {
//         this.numOccur = numOccur;
//     }
// }
// export module Keyword { }