import { Component, OnInit } from '@angular/core';
import { AbstractControl, Form, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ActivatedRoute, Router } from '@angular/router';
import { NomeId } from 'src/app/modelos/nome-id.modelo';
import { Produto } from 'src/app/modelos/produto.modelo';
import { DominioService } from 'src/app/servicos/dominio.service';
import { ProdutoService } from 'src/app/servicos/produto.service';

@Component({
  selector: 'app-produto-novo',
  templateUrl: './produto-novo.component.html',
  styleUrls: ['./produto-novo.component.scss']
})
export class ProdutoNovoComponent implements OnInit {
  categorias: Array<NomeId>;
  form: FormGroup;
  id: number;

  constructor(private dominioService: DominioService,
              private builder: FormBuilder,
              private router: Router,
              private route: ActivatedRoute,
              private snackBar: MatSnackBar,
              private produtoService: ProdutoService) {
      this.form = builder.group({ 
        codigoBarras: [ null, Validators.required ],
        nome: [ null, Validators.required ],
        valorCompra: [ null, Validators.required ],
        valorVenda: [ null, Validators.required ],
        categoriaId: [ null, Validators.required ],
        ncm: [ null, Validators.required ],
        cfop: [ null, Validators.required ],
        icmsSituacaoTributaria  : [ null, Validators.required ],
        percentualImposto: [ null ],
        foto: [ null],
      });
  }

  ngOnInit(): void {
    this.carregarCategorias();
    
    this.route.params.subscribe(x => {
      if(x['id']){
        this.id = +x['id'];
        this.produtoService.getById(this.id).subscribe(produto =>{
          this.form.reset(produto);
        })
      }
    });
  }

  carregarCategorias(){
    this.categorias = this.dominioService.categorias();
  }

  salvar(){
    this.form.controls.codigoBarras.setValue(this.form.controls.codigoBarras.value.toString());

    if(this.id){
      this.produtoService.put(this.form.value as Produto, `/${this.id}`).subscribe(
        (r) => {
          this.snackBar.open('Produto atualizado com sucesso', 'Ok');
        },
        (erro) => {
          this.snackBar.open(erro, 'Ok');
        }
      );  
    }else{
      this.produtoService.post(this.form.value as Produto).subscribe(
        (r) => {
          this.form.reset();
          this.snackBar.open('Produto cadastrado com sucesso', 'Ok');
        },
        (erro) => {
          this.snackBar.open(erro, 'Ok');
        }
      );
    }
  }

  obterMensagemErro(field: string) {
    const input: AbstractControl = this.form.get(field);
    if (!input) {
      return;
    }
    return input.hasError('required') ? 'Campo obrigatório' :
      input.hasError('minlength') ? `Mínimo ${input.getError('minlength').requiredLength} caracteres` :
          '';
  }
}
