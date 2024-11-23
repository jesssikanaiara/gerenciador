import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModalQuantidadeProdutoComponent } from './modal-quantidade-produto.component';

describe('ModalQuantidadeProdutoComponent', () => {
  let component: ModalQuantidadeProdutoComponent;
  let fixture: ComponentFixture<ModalQuantidadeProdutoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ModalQuantidadeProdutoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ModalQuantidadeProdutoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
