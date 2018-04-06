## Читать
- [XML Technologies](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M14.%20XML%20Technologies)
- [Serialization](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M15.%20Serialization)

## Материалы (презентация)
- [XML Technologies](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M14.%20XML%20Technologies)
- [Serialization](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M15.%20Serialization)

## Ключевые моменты
- Что такое XML 
- Что такое XSLT
- Что такое XPath
- Что такое XSD
- Что такое "well formed" XML документ
- Что такое "valid" XML документ?
- Способы валидации XML документа.
- .NET API интерфейсы для работы с  XML – данными.
- Различные механизмы сериализации


## Задачи (deadline )
  В текстовом файле построчно хранится информация об URL-адресах, представленных в виде <scheme>://<host>/<URL‐path>?<parameters>, где сегмент parameters - это набор пар вида key=value, при этом сегменты URL‐path и parameters  или сегмент parameters могут отсутствовать. 
Разработать систему типов (руководствоваться принципами SOLID) для экспорта данных, полученных на основе разбора информации текстового файла, в XML-документ по следующему правилу, например, для текстового файла с URL-адресами 
  - https://github.com/AnzhelikaKravchuk?tab=repositories 
  - https://github.com/AnzhelikaKravchuk/2017-2018.MMF.BSU
  - https://habrahabr.ru/company/it-grad/blog/341486/      

результирующим является XML-документ вида (можно использовать любую XML технологию без ограничений).
![XML-результат](https://github.com/AnzhelikaKravchuk/Training.-Spring-2018/blob/master/Pictures/XML.Task.png)

  Для тех URL-адресов, которые не совпадают с данным паттерном, “залогировать” информацию, отметив указанные строки, как необработанные. 
Продемонстрировать работу на примере консольного приложения.  

  Какие изменения нужно будет внести в систему типов, если в исходном  текстовом файле информация об URL-адресах изменится на другую, иерархически представимую информацию.
