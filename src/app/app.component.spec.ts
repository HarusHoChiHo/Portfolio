import { TestBed } from '@angular/core/testing';
import { AppComponent } from './app.component';
import {ActivatedRoute} from '@angular/router';
import {of} from 'rxjs';

describe('AppComponent', () => {
  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AppComponent],
      providers: [
        {
          provide: ActivatedRoute,
          useValue: {
            params: of({}),
            queryParams: {},
          }
        }
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
    expect(compiled.querySelector('a#nav_about')?.textContent).toContain('About');
    expect(compiled.querySelector('a#nav_contact')?.textContent).toContain('Contact');
    expect(compiled.querySelector('a#nav_projects')?.textContent).toContain('Projects');
  });
});
