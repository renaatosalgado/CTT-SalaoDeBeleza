INSERT [Cliente] ([Id], [Nome], [Telefone], [CPF]) VALUES (N'b530d124-ef22-4321-640c-08d8db538cb1', N'Thamirys', N'999999999', N'12345678901')
GO
INSERT [Cliente] ([Id], [Nome], [Telefone], [CPF]) VALUES (N'b9cc18c1-ea78-454e-640e-08d8db538cb1', N'Thaise', N'999999998', N'12345678902')
GO
INSERT [Servico] ([Id], [Nome], [MinutosParaExecucao], [Preco]) VALUES (N'4d43cd15-1928-4618-c276-08d8db472a2a', N'Corte de Cabelo', 59, CAST(130.00 AS Decimal(18, 2)))
GO
INSERT [Servico] ([Id], [Nome], [MinutosParaExecucao], [Preco]) VALUES (N'c5531f32-8fcb-4d03-c277-08d8db472a2a', N'Manicure', 59, CAST(20.00 AS Decimal(18, 2)))
GO
INSERT [Servico] ([Id], [Nome], [MinutosParaExecucao], [Preco]) VALUES (N'fda806d3-c1e7-4c9b-c278-08d8db472a2a', N'Pedicure', 59, CAST(30.00 AS Decimal(18, 2)))
GO
INSERT [Servico] ([Id], [Nome], [MinutosParaExecucao], [Preco]) VALUES (N'9d932de6-5853-48bf-c27a-08d8db472a2a', N'Limpeza de pele', 59, CAST(100.00 AS Decimal(18, 2)))
GO
INSERT [Endereco] ([Id], [Logradouro], [CEP], [Bairro], [Cidade], [UF], [Numero], [Complemento]) VALUES (N'4dc9a5e4-f95a-40dd-78bf-08d8db488ac0', N'Rua dos bobos', N'12345010', N'Vila dos Devs', N'São Paulo', N'SP', N'0', NULL)
GO
INSERT [Turno] ([Id], [TipoTurno], [EntradaSemana], [SaidaSemana], [EntradaSabado], [SaidaSabado]) VALUES (N'29227270-ba22-41e8-e84b-08d8db465c2c', 1, CAST(N'1900-01-01T12:00:00.0000000' AS DateTime2), CAST(N'1900-01-01T18:00:00.0000000' AS DateTime2), CAST(N'1900-01-01T12:00:00.0000000' AS DateTime2), CAST(N'1900-01-01T18:00:00.0000000' AS DateTime2))
GO
INSERT [Turno] ([Id], [TipoTurno], [EntradaSemana], [SaidaSemana], [EntradaSabado], [SaidaSabado]) VALUES (N'a4a77b69-35eb-4915-e84c-08d8db465c2c', 0, CAST(N'1900-01-01T08:00:00.0000000' AS DateTime2), CAST(N'1900-01-01T12:00:00.0000000' AS DateTime2), CAST(N'1900-01-01T08:00:00.0000000' AS DateTime2), CAST(N'1900-01-01T12:00:00.0000000' AS DateTime2))
GO
INSERT [Funcionario] ([Id], [Matricula], [Nome], [Telefone], [Cargo], [EnderecoId], [TurnoId]) VALUES (N'9802275c-8b6e-4dd6-4593-08d8db4a64f1', N'1', N'Maria', N'999999999', 0, N'4dc9a5e4-f95a-40dd-78bf-08d8db488ac0', N'29227270-ba22-41e8-e84b-08d8db465c2c')
GO
INSERT [Funcionario] ([Id], [Matricula], [Nome], [Telefone], [Cargo], [EnderecoId], [TurnoId]) VALUES (N'bf4f187b-1c6e-4f06-4594-08d8db4a64f1', N'1', N'Rosana', N'999999998', 1, N'4dc9a5e4-f95a-40dd-78bf-08d8db488ac0', N'a4a77b69-35eb-4915-e84c-08d8db465c2c')
GO
INSERT [Funcionario] ([Id], [Matricula], [Nome], [Telefone], [Cargo], [EnderecoId], [TurnoId]) VALUES (N'669f8828-548f-486c-4596-08d8db4a64f1', N'1', N'Joana', N'999999997', 2, N'4dc9a5e4-f95a-40dd-78bf-08d8db488ac0', N'29227270-ba22-41e8-e84b-08d8db465c2c')
GO
INSERT [ServicoSolicitado] ([Id], [Status], [DataServico], [Preco], [FuncionarioId], [ServicoId]) VALUES (N'95f3420e-c9a1-4bee-81fc-08d8db5226ed', 0, CAST(N'2021-03-01T16:00:00.0000000' AS DateTime2), CAST(130.00 AS Decimal(18, 2)), N'9802275c-8b6e-4dd6-4593-08d8db4a64f1', N'4d43cd15-1928-4618-c276-08d8db472a2a')
GO
INSERT [Agendamento] ([Id], [ClienteId], [ServicoSolicitadoId], [DataChegada], [Anotacao], [Status], [DataAgendamento]) VALUES (N'e2855689-2819-4f4b-cd7f-08d8db561122', N'b530d124-ef22-4321-640c-08d8db538cb1', N'95f3420e-c9a1-4bee-81fc-08d8db5226ed', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'Via API', 0, CAST(N'2021-03-01T11:00:00.0000000' AS DateTime2))
GO
INSERT [FuncionarioServico] ([FuncionarioId], [ServicoId], [Id]) VALUES (N'bf4f187b-1c6e-4f06-4594-08d8db4a64f1', N'c5531f32-8fcb-4d03-c277-08d8db472a2a', N'0d9886f9-f7a2-4046-bf0f-2b90294d4765')
GO
INSERT [FuncionarioServico] ([FuncionarioId], [ServicoId], [Id]) VALUES (N'bf4f187b-1c6e-4f06-4594-08d8db4a64f1', N'fda806d3-c1e7-4c9b-c278-08d8db472a2a', N'6c3eee48-0944-4198-b700-d6d2c744d391')
GO
INSERT [FuncionarioServico] ([FuncionarioId], [ServicoId], [Id]) VALUES (N'669f8828-548f-486c-4596-08d8db4a64f1', N'9d932de6-5853-48bf-c27a-08d8db472a2a', N'1a90dfff-16ea-4a37-aa5d-a7bb7bd568d4')
GO
