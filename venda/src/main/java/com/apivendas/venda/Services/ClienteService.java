package com.apivendas.venda.Services;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import java.util.*;
import com.apivendas.venda.DTO.ClienteDTO;
import com.apivendas.venda.Models.Cliente;
import com.apivendas.venda.Repository.ClienteRepository;

import jakarta.persistence.EntityNotFoundException;

@Service
public class ClienteService {

    @Autowired
    private ClienteRepository clienteRepository;

    public ClienteDTO login(String email, String senha) {

        Cliente cliente = clienteRepository.findByEmailandSenha(email, senha)
                .orElseThrow(() -> new EntityNotFoundException("Usuario ou senha invalido."));

        /*
         * return new ClienteDTO(Cliente.getId(), Cliente.getBairro(), Cliente.getCep(),
         * Cliente.getCidade(),
         * Cliente.getData_criacao(), Cliente.getComplemento(), Cliente.getNome(),
         * Cliente.getNumero(),
         * Cliente.getRua());
         */

        return new ClienteDTO(cliente.getId(), cliente.getNome(), cliente.getEmail(), cliente.getCpf(),
                cliente.getCep(), cliente.getRua(), cliente.getBairro(), cliente.getCidade(), cliente.getNumero(),
                cliente.getComplemento(), cliente.getTelefone(), cliente.getSenha(), cliente.getNome_usuario(),
                cliente.getData_criacao(), cliente.getRole());
    }

}
