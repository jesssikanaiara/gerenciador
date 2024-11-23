import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Cliente } from 'src/app/modelos/cliente.modelo';
import { FiltroPaginacao } from 'src/app/modelos/filtro-paginacao.modelo';
import { ClienteService } from 'src/app/servicos/cliente.service';

@Component({
  selector: 'app-clientes',
  templateUrl: './clientes.component.html',
  styleUrls: ['./clientes.component.scss']
})
export class ClientesComponent implements OnInit {
  form: FormGroup;
  clientes: Array<Cliente>;

  totalItens = 100;
  itensPorPagina = 10;
  paginaAtual = 0;
  paginaOpcoes: number[] = [5, 10, 25, 100];


  colunas: string[] = ['id', 'nome', 'sobrenome', 'telefone'];

  constructor(private clienteService: ClienteService) {
  }

  ngOnInit(): void {
    this.carregarClientes();
  }

  paginaAlterada(evento) {
    this.paginaAtual = evento.pageIndex;
    this.itensPorPagina = evento.pageSize;
    this.carregarClientes();
  }

  carregarClientes() {
    const param = new FiltroPaginacao();
    param.itensPorPagina = this.itensPorPagina;
    param.pagina = this.paginaAtual + 1;

    this.clienteService.filtrar('', param).subscribe(
      (clientes) => {
        this.clientes = clientes.lista;
        this.totalItens = clientes.totalItens;
      }
    );
  }
}
