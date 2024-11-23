import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { MatBottomSheetRef } from '@angular/material/bottom-sheet';

@Component({
  selector: 'app-modal-quantidade-produto',
  templateUrl: './modal-quantidade-produto.component.html',
  styleUrls: ['./modal-quantidade-produto.component.scss']
})
export class ModalQuantidadeProdutoComponent implements OnInit {
  @ViewChild("txtquantidade") txtQuantidade: ElementRef;
  quantidade: number = 1;

  constructor(private _bottomSheetRef: MatBottomSheetRef<ModalQuantidadeProdutoComponent>) { }

  ngOnInit(): void {
    setTimeout(() => {
      this.txtQuantidade.nativeElement.focus();      
      this.txtQuantidade.nativeElement.select();      
    }, 200);
  }
  
  enviar(){
    if(this.quantidade > 0){
      this._bottomSheetRef.dismiss(this.quantidade);
    }
  }
}
