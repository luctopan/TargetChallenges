# ♦️ TargetChallenges

Este projeto reúne soluções para desafios de lógica propostos pela **Target Sistemas**, implementados em **C# com .NET Console Application**.

---

## 📌 Respostas dos Desafios

### 🔢 Desafio 1 — Soma usando `while`
> **Resposta:** `91`

### 🧮 Desafio 2 — Sequência de Fibonacci
> **Resposta:** De acordo com a entrada do usuário

### 📊 Desafio 3 — Análise de Faturamento Diário
> **Resposta:**
- 📊 **Média mensal:** `R$ 48.924,24`
- 📈 **Maior valor do mês:** `R$ 373,78`
- 📉 **Menor valor do mês:** `R$ 20.865,37`
- 📅 **Dias acima da média:** `10`

### 🗺️ Desafio 4 — Percentual de Faturamento por Estado
> **Resposta:**  
**Faturamento Total:** `R$ 180.759,98`

| Estado  | Participação     | Percentual |
|---------|------------------|------------|
| SP      | R$ 67.836,43     | 37,53%     |
| RJ      | R$ 36.678,66     | 20,29%     |
| MG      | R$ 29.229,88     | 16,17%     |
| ES      | R$ 27.165,48     | 15,03%     |
| Outros  | R$ 19.849,53     | 10,98%     |

### 🔄 Desafio 5 — Inversão de String
> **Resposta:** De acordo com a entrada do usuário

---

## 🧱 Estrutura do Projeto

```
TargetChallenges/
├── Challenges/           # Lógica dos desafios
├── Data/
│   ├── Json/             # Arquivos .json com os dados de faturamento
│   └── Mappings/         # Modelos para desserialização
├── Infrastructure/
│   └── Utils/            # Utilitários genéricos
├── UI/                   # Interface de console
└── Program.cs            # Ponto de entrada do projeto
```

---

## 📂 Classes Principais

| Classe         | Desafio       |
|----------------|---------------|
| `While.cs`     | Desafio 1     |
| `Fibonacci.cs` | Desafio 2     |
| `Revenue.cs`   | Desafio 3     |
| `Percentage.cs`| Desafio 4     |
| `Reverser.cs`  | Desafio 5     |

---

## ▶️ Como Executar

```bash
dotnet build
dotnet run
```

> **Pré-requisitos:** [.NET SDK](https://dotnet.microsoft.com/en-us/download) instalado na máquina.

---

## 💬 Comentários Finais

- O projeto foi desenvolvido como uma aplicação de console para facilitar testes e execuções;
- A estrutura `Data/Mappings` simula um mapeamento de dados semelhante ao uso do Entity Framework com SQL Server;
- Os arquivos JSON foram adaptados para manter o contexto dos desafios:
  - `dados.json` foi renomeado para `dailyRevenue.json`;
  - `stateRevenue.json` foi criado para representar o desafio de faturamento por estado;
- Técnicas variadas foram aplicadas, como orientação a objetos, validação de entrada, e separação por responsabilidades.

---