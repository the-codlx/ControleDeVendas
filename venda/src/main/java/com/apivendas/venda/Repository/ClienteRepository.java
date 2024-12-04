package com.apivendas.venda.Repository;

import com.apivendas.venda.Models.Cliente;

import org.springframework.data.jpa.repository.JpaRepository;
import java.util.List;
import java.util.Optional;

public interface ClienteRepository extends JpaRepository<Cliente, Integer> {
    Optional<Cliente> findByEmailandSenha(String email, String senha);

}
