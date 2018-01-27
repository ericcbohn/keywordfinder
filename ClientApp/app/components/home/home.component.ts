import { Component, Inject } from '@angular/core';
import { FormBuilder, FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent {
    rForm: FormGroup;
    jobPost: string;

    // inject instance of FormBuilder
    constructor(private fb: FormBuilder) {
        this.rForm = fb.group({
            jobPost: ['', Validators.required]
        });
    }

    addPost(post: any) {
        this.jobPost = post.jobPost;
    }
}
