import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class KeywordService {

    constructor(private httpClient: HttpClient) { }

    // TODO: implement caching
    getKeywords(): Keyword[] {
        var words:Keyword[] = [];
        this.httpClient.get<Keywords>('/home/getkeywords').subscribe(data => { 
            words = data.words;
        });
        return words;
    }

    setJobPost(jobPost:string): void {
        this.httpClient.post('/home/setjobpost', jobPost).subscribe();
    }
}

// interface Keywords {
//     words:Keyword[];
// }

// interface Keyword {
//     word:string;
//     occurances:number;
// }