import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormControl, Validators } from '@angular/forms';
import { KeywordService } from '../../services/keyword/keyword.service';

@Component({
    selector: 'keyword',
    templateUrl: './keyword.component.html',
    //styleUrls: ['./keyword.component.css']
})
export class KeywordComponent {
    keywords: Keyword[];

    constructor(private keywordService: KeywordService) { }

    ngOnInit() {
        this.getKeywords();
    }

    getKeywords(): void {
        this.keywords = this.keywordService.getKeywords();
    }
}
