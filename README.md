# 🍅 Demo Blazor Pomodoro

Aplicação web moderna de **Pomodoro Timer** desenvolvida em **Blazor Server** com .NET 10, design responsivo mobile-first e tema claro/escuro.

![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet)
![Blazor](https://img.shields.io/badge/Blazor-Server-512BD4?logo=blazor)
![License](https://img.shields.io/badge/license-MIT-green)

## 📖 Sobre o Projeto

Timer Pomodoro para gestão de tempo e produtividade baseado na **Técnica Pomodoro** - intervalos de trabalho focado seguidos de pausas. Interface moderna, responsiva e com suporte completo a temas claro/escuro.

## ✨ Funcionalidades

### Core Features
- ⏱️ **Timer Pomodoro** com duração personalizável
- ☕ **Short Break** - pausas curtas entre pomodoros
- 🌴 **Long Break** - pausas longas após múltiplos ciclos
- ⚙️ **Configurações** completas de duração
- 💾 **Persistência local** via LocalStorage
- 📊 **Contador diário** de pomodoros completados
- 🔔 **Notificação sonora** ao completar cada sessão

### Design & UX
- 🎨 **Design moderno** com gradientes e animações suaves
- 🌓 **Tema claro/escuro** com toggle instantâneo
- 📱 **Mobile-first** - 100% responsivo
- ♿ **Acessível** - suporte a teclado e screen readers
- 🎯 **Estados visuais** claros para cada tipo de timer

## 🚀 Como Executar

### Pré-requisitos
- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) instalado

### Execução

```powershell
# Clone o repositório
git clone https://github.com/seu-usuario/demo-blazor-pomodoro.git

# Navegue até o diretório
cd demo-blazor-pomodoro/src

# Restaure as dependências
dotnet restore

# Execute a aplicação
dotnet run

# Ou use watch para hot reload
dotnet watch run
```

### Acesso
- **HTTPS**: https://localhost:7001
- **HTTP**: http://localhost:5100

## 🛠️ Tecnologias

### Backend
- **.NET 10.0** - Framework mais recente
- **Blazor Server** - UI framework com SignalR
- **C# 13** - Linguagem moderna

### Frontend
- **Blazored.LocalStorage 4.5.0** - Persistência local
- **Bootstrap 5** - Grid system
- **CSS Custom Properties** - Sistema de temas
- **Modern CSS** - Gradientes, animações, flexbox/grid

### Arquitetura
- **Minimal APIs** - Program.cs simplificado
- **Component-based** - Arquitetura Blazor
- **Async/await** - PeriodicTimer para timer assíncrono
- **IDisposable** - Gerenciamento adequado de recursos

## 📱 Responsividade

Design mobile-first com breakpoints:
- **Mobile**: < 576px (base)
- **Tablet**: ≥ 768px
- **Desktop**: ≥ 992px
- **Large**: ≥ 1200px

## 🌓 Tema Claro/Escuro

- Toggle instantâneo no navbar (☀️/🌙)
- Detecta preferência do sistema automaticamente
- Persistência da escolha do usuário
- Sem flash ao carregar (FOUC prevention)
- Todas as cores adaptadas via CSS Variables

## 📁 Estrutura do Projeto

```
demo-blazor-pomodoro/
├── src/
│   ├── Pages/
│   │   ├── Index.razor          # Página principal do timer
│   │   ├── Settings.razor       # Configurações
│   │   └── _Host.cshtml         # HTML host
│   ├── Shared/
│   │   ├── MainLayout.razor     # Layout principal + theme toggle
│   │   └── ...
│   ├── Model/
│   │   └── PomodoroSettings.cs  # Modelo de configurações
│   ├── wwwroot/
│   │   └── css/
│   │       └── site.css         # Estilos personalizados
│   ├── Program.cs               # Entry point (Minimal API)
│   └── demo-blazor-pomodoro.csproj
├── README.md
└── MELHORIAS.md                 # Roadmap e melhorias propostas
```

## 🔄 Atualizações Recentes (Dez/2025)

### Versão 2.0 - Redesign Completo
- ✅ **Migrado .NET 8 → .NET 10**
- ✅ **Modernizado para Minimal APIs** (removido Startup.cs)
- ✅ **Design completamente reformulado**
  - Interface moderna com gradientes
  - Sistema de cores CSS Variables
  - Animações e transições suaves
- ✅ **Tema claro/escuro implementado**
  - Toggle funcional
  - Detecção automática de preferência
  - Persistência da escolha
- ✅ **Mobile-first responsive design**
- ✅ **Corrigido bug crítico do timer**
  - Substituído System.Timers.Timer por PeriodicTimer
  - Implementado InvokeAsync para atualização da UI
- ✅ **Pacotes atualizados**
  - Blazored.LocalStorage 3.0.0 → 4.5.0
- ✅ **Novas funcionalidades**
  - Contador de pomodoros diários
  - Notificação sonora
  - Estados visuais aprimorados

## 🐛 Correções de Bugs

1. **Timer não atualizava UI**: Substituído timer obsoleto por PeriodicTimer com InvokeAsync
2. **JavaScript Interop durante prerendering**: Movido para OnAfterRenderAsync
3. **Memory leaks**: Implementado IDisposable e CancellationToken adequadamente
4. **Anti-pattern DateTime**: Substituído por TimeSpan para durações

## 📚 Próximos Passos

Veja [MELHORIAS.md](MELHORIAS.md) para roadmap detalhado:
- [ ] Clean Architecture (camadas separadas)
- [ ] Sistema de histórico e estatísticas
- [ ] Projetos/Tags para categorização
- [ ] PWA (Progressive Web App)
- [ ] Sincronização em nuvem
- [ ] Modo multiplayer/equipes

## 🤝 Contribuindo

Contribuições são bem-vindas! Por favor:
1. Fork o projeto
2. Crie uma branch para sua feature (`git checkout -b feature/MinhaFeature`)
3. Commit suas mudanças (`git commit -m 'Adiciona MinhaFeature'`)
4. Push para a branch (`git push origin feature/MinhaFeature`)
5. Abra um Pull Request

## 📄 Licença

Este projeto está sob a licença MIT. Veja o arquivo LICENSE para mais detalhes.

## 👨‍💻 Autor

Desenvolvido como projeto de demonstração de Blazor Server e boas práticas .NET.

## 🙏 Agradecimentos

- Técnica Pomodoro criada por Francesco Cirillo
- Comunidade Blazor e .NET
- Contributors do Blazored.LocalStorage

---

⭐ Se este projeto foi útil, considere dar uma estrela!

**Status**: ✅ Pronto para produção | 🚀 .NET 10 | 🎨 Design moderno | 📱 Mobile-first
