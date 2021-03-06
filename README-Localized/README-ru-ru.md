---
page_type: sample
products:
- office-365
- ms-graph
languages:
- csharp
extensions:
  contentType: samples 
  technologies:
  - Microsoft Graph
  services:
  - Office 365
  createdDate: 5/8/2017 5:02:44 PM
---

# Создание комплексных решений с использованием Microsoft Graph и Common Data Service

## Обзор
> **Примечание** это решение, публикуемое в рамках сеанса Microsoft Build 2017 [P4136](https://channel9.msdn.com/Events/Build/2017/P4136). Он содержит несколько проектов, которые используют Microsoft Graph и Common Data Service, технологии Xamarin.

Microsoft предоставляет платформу для создания комплексных решений. В этом примере показано, как профессиональные разработчики могут создавать основанные на них приложения, работающие с большими объемами данных, которые применяют продуктивность и бизнес-данные, из [Microsoft Graph](https://graph.microsoft.com "Microsoft Graph") и [общей службой данных](https://aka.ms/CommonDataService "общей службой данных Microsoft"). И как опытные пользователи могут использовать эти данные для создания приложений, потоков и информационных панелей.

[Microsoft Graph](https://graph.microsoft.com "Microsoft Graph") — это единое API для сервисов Microsoft. Это включает Office 365, Azure Active Directory и многие другие.

[Служба общих данных Microsoft ](https://aka.ms/CommonDataService "Служба общих данных Microsoft") или CDS - это центр данных предприятия. Профессиональные разработчики могут писать приложения, которые взаимодействуют с этими данными в CDS, а опытные пользователи могут использовать преимущества PowerApps, Flow и PowerBI для создания приложений, разработки рабочих процессов и выполнения глубокого анализа этих данных без написания какого-либо кода.

Microsoft Graph дает вам доступ к богатым данным из служб Microsoft. Как только вы перенесете эти данные в CDS, вы сможете объединить их с другими бизнес-данными, от которых зависит ваш бизнес. Затем вы можете создавать многофункциональные приложения и рабочие процессы с помощью простых в использовании строительных блоков (таких как [PowerApps](https://powerapps.microsoft.com/en-us/), [Flow](https://flow.microsoft.com/en-us/), [PowerBI](https://powerbi.microsoft.com/en-us/)), независимо от того, знаете ли вы, как писать код или нет. Таким образом, с помощью Microsoft Graph и Common Data Service разработчики могут не только создавать ориентированные на людей приложения, насыщенные данными, но и расширять приложение для опытных пользователей, которые не являются обычными программистами, чтобы получить дополнительный опыт.

## Какие сценарии охватываются этим образцом?
Образцы, опубликованные в рамках этого проекта, построены на основе следующего сценария:

### Сценарий профессионального разработчика приложения
Многие компании сталкиваются с проблемами облегчения поездок на работу и парковки для своих сотрудников. Они ищут решения. Профессиональный разработчик приложений работает над решением этой проблемы. Она создает мобильное приложение, которое помогает людям находить поездки на работу и с работы. Это приложение хорошо вписывается в то, как люди на самом деле работают. и так как это приложение может быть развернуто во многих компаниях.

<img src="./media/prodevScenario.jpg" Height="80%" Width="80%" />

### Сценарий корпоративных пользователей
Contoso является одним из первых клиентов, которые приобрели это приложение и сделали его доступным для всех своих сотрудников. Опытные пользователи Contoso (как правило, непрофессиональные программисты, такие как сотрудник отдела кадров) легко расширяют данные, создаваемые этим приложением, для создания дополнительных возможностей.

<img src="./media/poweruserScenario.jpg" Height="80%" Width="80%" />

## Что входит в этот проект?

Пожалуйста, перейдите по ссылкам, приведенным ниже, чтобы узнать, как отдельные части были построены и воссоздать комплексный опыт для себя.

### Профессиональный разработчик приложения - создайте приложение, используя код
- [Мобильное приложение ](./mobileapp/README.md) — приложения Xamarin Forms, которые используют API Microsoft Graph для хранения данных и магазинов в общей службе данных через веб-API.

### Опытные пользователи предприятия - используйте данные и расширяйте решение, не используя код
- [CDS](./cds/README.md) — в качестве репозитория данных для мобильного приложения используется общедоступная служба данных, которая будет использоваться для хранения данных PowerApps, Flow и PowerBI.
- [приложение PowerApps](./powerapps/README.md)-PowerApps создано в корпоративной среде, в котором используется приложение Excel вроде языка выражений, чтобы создать мобильное приложение с учетом написания кода.
- [Flow](./flow/README.md) — рабочий процесс утверждения расходов, созданный корпоративным администратором, который использует Microsoft Flow, отправляющий сообщения электронной почты руководителю и другим отделам.
- панель мониторинга [PowerBI](./powerbi/README.md) — панель мониторинга, созданная администратором предприятия опытного пользователя, которая помогает проанализировать данные.

### Технический обзор

<img src="./media/workridesTech.jpg" Height="80%" Width="80%" />

## Подробнее
- [Microsoft Graph](https://graph.microsoft.com "Microsoft Graph")
- [Служба стандартных данных Майкрософт](https://aka.ms/CommonDataService "общей службой данных Майкрософт")
