import {TestBed} from '@angular/core/testing';
import {AppComponent} from './app.component';
import {ActivatedRoute} from '@angular/router';
import {of} from 'rxjs';
import {provideAnimationsAsync} from "@angular/platform-browser/animations/async";

describe('AppComponent', () => {
    beforeEach(async () => {
        await TestBed.configureTestingModule({
            imports  : [AppComponent],
            providers: [
                {
                    provide : ActivatedRoute,
                    useValue: {
                        params     : of({}),
                        queryParams: {},
                    }
                },
                provideAnimationsAsync(),
            ]
        }).compileComponents();
    });

    it('should create the app', () => {
        const fixture = TestBed.createComponent(AppComponent);
        const app = fixture.componentInstance;
        expect(app).toBeTruthy();
    });

    it('should render nav bar', () => {
        const fixture = TestBed.createComponent(AppComponent);
        fixture.detectChanges();
        const compiled = fixture.nativeElement as HTMLElement;
        expect(compiled.querySelector('#projects')?.textContent).toBeTruthy();
    });
});
