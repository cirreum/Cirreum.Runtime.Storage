# {REPO-NAME}

[![NuGet Version](https://img.shields.io/nuget/v/{REPO-NAME}.svg?style=flat-square&labelColor=1F1F1F&color=003D8F)](https://www.nuget.org/packages/{REPO-NAME}/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/{REPO-NAME}.svg?style=flat-square&labelColor=1F1F1F&color=003D8F)](https://www.nuget.org/packages/{REPO-NAME}/)
[![GitHub Release](https://img.shields.io/github/v/release/cirreum/{REPO-NAME}?style=flat-square&labelColor=1F1F1F&color=FF3B2E)](https://github.com/cirreum/{REPO-NAME}/releases)
[![License](https://img.shields.io/github/license/cirreum/{REPO-NAME}?style=flat-square&labelColor=1F1F1F&color=F2F2F2)](https://github.com/cirreum/{REPO-NAME}/blob/main/LICENSE)
[![.NET](https://img.shields.io/badge/.NET-10.0-003D8F?style=flat-square&labelColor=1F1F1F)](https://dotnet.microsoft.com/)

**{TAG LINE}**

## Overview

**{REPO-NAME}** {REPO-DESCRIPTION}.

{READ-ME-CONTENT}

## Documentation

{ANY OTHER DOCS - OTHERWISE REMOVE}

## Contribution Guidelines

1. **Be conservative with new abstractions**  
   The API surface must remain stable and meaningful.

2. **Limit dependency expansion**  
   Only add foundational, version-stable dependencies.

3. **Favor additive, non-breaking changes**  
   Breaking changes ripple through the entire ecosystem.

4. **Include thorough unit tests**  
   All primitives and patterns should be independently testable.

5. **Document architectural decisions**  
   Context and reasoning should be clear for future maintainers.

6. **Follow .NET conventions**  
   Use established patterns from Microsoft.Extensions.* libraries.

## Versioning

{REPO-NAME} follows [Semantic Versioning](https://semver.org/):

- **Major** - Breaking API changes
- **Minor** - New features, backward compatible
- **Patch** - Bug fixes, backward compatible

Given its foundational role, major version bumps are rare and carefully considered.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

**Cirreum Foundation Framework**  
*Layered simplicity for modern .NET*