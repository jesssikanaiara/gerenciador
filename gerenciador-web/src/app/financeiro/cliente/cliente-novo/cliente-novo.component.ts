import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Cliente } from 'src/app/modelos/cliente.modelo';
import { ClienteService } from 'src/app/servicos/cliente.service';

@Component({
  selector: 'app-cliente-novo',
  templateUrl: './cliente-novo.component.html',
  styleUrls: ['./cliente-novo.component.scss']
})
export class ClienteNovoComponent implements OnInit {
  form: FormGroup;

  constructor(private builder: FormBuilder,
              private clienteService: ClienteService) {
    this.form = builder.group({ 
      nome: [ null, Validators.required ],
      sobrenome: [ null],
      telefone: [ null ]       
    });
  }

  ngOnInit(): void {
  }

  salvar(){
    this.clienteService.post(this.form.value as Cliente).subscribe(
      (r) => {
        console.log(r);
      },
      (erro) => {
        console.log(erro);
      }
    );
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
