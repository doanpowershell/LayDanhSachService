﻿$ip=read-host "địa chỉ IP"
$tk=read-host "Nhập TK"
gwmi win32_service -ComputerName $ip -Credential $tk | select Name