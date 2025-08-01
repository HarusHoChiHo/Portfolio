import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjectsComponent } from './projects.component';
import {provideAnimations} from "@angular/platform-browser/animations";
import {provideAnimationsAsync} from "@angular/platform-browser/animations/async";

describe('ProjectsComponent', () => {
  let component: ProjectsComponent;
  let fixture: ComponentFixture<ProjectsComponent>;
  let compiled: HTMLElement;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ProjectsComponent],
      providers: [provideAnimationsAsync()]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProjectsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
    compiled = fixture.nativeElement as HTMLElement;
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should have all titles', () => {
    expect(compiled.querySelector('#p_panel_online_shop h2')?.textContent).toContain('Online Shop');
    expect(compiled.querySelector('#p_panel_rfps_rust h2')?.textContent).toContain('RFPS back end application');
    expect(compiled.querySelector('#p_panel_blog_system h2')?.textContent).toContain('Blog System');
    expect(compiled.querySelector('#p_panel_rfps h2')?.textContent).toContain('Restaurant Food Planning System');
    expect(compiled.querySelector('#p_panel_sentiment_analysis h2')?.textContent).toContain('Sentiment Analysis');
  });
});
