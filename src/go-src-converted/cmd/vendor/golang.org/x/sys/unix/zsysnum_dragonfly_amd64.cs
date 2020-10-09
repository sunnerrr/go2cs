// go run mksysnum.go https://gitweb.dragonflybsd.org/dragonfly.git/blob_plain/HEAD:/sys/kern/syscalls.master
// Code generated by the command above; see README.md. DO NOT EDIT.

// +build amd64,dragonfly

// package unix -- go2cs converted at 2020 October 09 06:00:25 UTC
// import "cmd/vendor/golang.org/x/sys/unix" ==> using unix = go.cmd.vendor.golang.org.x.sys.unix_package
// Original source: C:\Go\src\cmd\vendor\golang.org\x\sys\unix\zsysnum_dragonfly_amd64.go

using static go.builtin;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
 
        // SYS_NOSYS = 0;  // { int nosys(void); } syscall nosys_args int
        public static readonly long SYS_EXIT = (long)1L; // { void exit(int rval); }
        public static readonly long SYS_FORK = (long)2L; // { int fork(void); }
        public static readonly long SYS_READ = (long)3L; // { ssize_t read(int fd, void *buf, size_t nbyte); }
        public static readonly long SYS_WRITE = (long)4L; // { ssize_t write(int fd, const void *buf, size_t nbyte); }
        public static readonly long SYS_OPEN = (long)5L; // { int open(char *path, int flags, int mode); }
        public static readonly long SYS_CLOSE = (long)6L; // { int close(int fd); }
        public static readonly long SYS_WAIT4 = (long)7L; // { int wait4(int pid, int *status, int options, struct rusage *rusage); } wait4 wait_args int
        public static readonly long SYS_LINK = (long)9L; // { int link(char *path, char *link); }
        public static readonly long SYS_UNLINK = (long)10L; // { int unlink(char *path); }
        public static readonly long SYS_CHDIR = (long)12L; // { int chdir(char *path); }
        public static readonly long SYS_FCHDIR = (long)13L; // { int fchdir(int fd); }
        public static readonly long SYS_MKNOD = (long)14L; // { int mknod(char *path, int mode, int dev); }
        public static readonly long SYS_CHMOD = (long)15L; // { int chmod(char *path, int mode); }
        public static readonly long SYS_CHOWN = (long)16L; // { int chown(char *path, int uid, int gid); }
        public static readonly long SYS_OBREAK = (long)17L; // { int obreak(char *nsize); } break obreak_args int
        public static readonly long SYS_GETFSSTAT = (long)18L; // { int getfsstat(struct statfs *buf, long bufsize, int flags); }
        public static readonly long SYS_GETPID = (long)20L; // { pid_t getpid(void); }
        public static readonly long SYS_MOUNT = (long)21L; // { int mount(char *type, char *path, int flags, caddr_t data); }
        public static readonly long SYS_UNMOUNT = (long)22L; // { int unmount(char *path, int flags); }
        public static readonly long SYS_SETUID = (long)23L; // { int setuid(uid_t uid); }
        public static readonly long SYS_GETUID = (long)24L; // { uid_t getuid(void); }
        public static readonly long SYS_GETEUID = (long)25L; // { uid_t geteuid(void); }
        public static readonly long SYS_PTRACE = (long)26L; // { int ptrace(int req, pid_t pid, caddr_t addr, int data); }
        public static readonly long SYS_RECVMSG = (long)27L; // { int recvmsg(int s, struct msghdr *msg, int flags); }
        public static readonly long SYS_SENDMSG = (long)28L; // { int sendmsg(int s, caddr_t msg, int flags); }
        public static readonly long SYS_RECVFROM = (long)29L; // { int recvfrom(int s, caddr_t buf, size_t len, int flags, caddr_t from, int *fromlenaddr); }
        public static readonly long SYS_ACCEPT = (long)30L; // { int accept(int s, caddr_t name, int *anamelen); }
        public static readonly long SYS_GETPEERNAME = (long)31L; // { int getpeername(int fdes, caddr_t asa, int *alen); }
        public static readonly long SYS_GETSOCKNAME = (long)32L; // { int getsockname(int fdes, caddr_t asa, int *alen); }
        public static readonly long SYS_ACCESS = (long)33L; // { int access(char *path, int flags); }
        public static readonly long SYS_CHFLAGS = (long)34L; // { int chflags(char *path, int flags); }
        public static readonly long SYS_FCHFLAGS = (long)35L; // { int fchflags(int fd, int flags); }
        public static readonly long SYS_SYNC = (long)36L; // { int sync(void); }
        public static readonly long SYS_KILL = (long)37L; // { int kill(int pid, int signum); }
        public static readonly long SYS_GETPPID = (long)39L; // { pid_t getppid(void); }
        public static readonly long SYS_DUP = (long)41L; // { int dup(int fd); }
        public static readonly long SYS_PIPE = (long)42L; // { int pipe(void); }
        public static readonly long SYS_GETEGID = (long)43L; // { gid_t getegid(void); }
        public static readonly long SYS_PROFIL = (long)44L; // { int profil(caddr_t samples, size_t size, size_t offset, u_int scale); }
        public static readonly long SYS_KTRACE = (long)45L; // { int ktrace(const char *fname, int ops, int facs, int pid); }
        public static readonly long SYS_GETGID = (long)47L; // { gid_t getgid(void); }
        public static readonly long SYS_GETLOGIN = (long)49L; // { int getlogin(char *namebuf, u_int namelen); }
        public static readonly long SYS_SETLOGIN = (long)50L; // { int setlogin(char *namebuf); }
        public static readonly long SYS_ACCT = (long)51L; // { int acct(char *path); }
        public static readonly long SYS_SIGALTSTACK = (long)53L; // { int sigaltstack(stack_t *ss, stack_t *oss); }
        public static readonly long SYS_IOCTL = (long)54L; // { int ioctl(int fd, u_long com, caddr_t data); }
        public static readonly long SYS_REBOOT = (long)55L; // { int reboot(int opt); }
        public static readonly long SYS_REVOKE = (long)56L; // { int revoke(char *path); }
        public static readonly long SYS_SYMLINK = (long)57L; // { int symlink(char *path, char *link); }
        public static readonly long SYS_READLINK = (long)58L; // { int readlink(char *path, char *buf, int count); }
        public static readonly long SYS_EXECVE = (long)59L; // { int execve(char *fname, char **argv, char **envv); }
        public static readonly long SYS_UMASK = (long)60L; // { int umask(int newmask); } umask umask_args int
        public static readonly long SYS_CHROOT = (long)61L; // { int chroot(char *path); }
        public static readonly long SYS_MSYNC = (long)65L; // { int msync(void *addr, size_t len, int flags); }
        public static readonly long SYS_VFORK = (long)66L; // { pid_t vfork(void); }
        public static readonly long SYS_SBRK = (long)69L; // { int sbrk(int incr); }
        public static readonly long SYS_SSTK = (long)70L; // { int sstk(int incr); }
        public static readonly long SYS_MUNMAP = (long)73L; // { int munmap(void *addr, size_t len); }
        public static readonly long SYS_MPROTECT = (long)74L; // { int mprotect(void *addr, size_t len, int prot); }
        public static readonly long SYS_MADVISE = (long)75L; // { int madvise(void *addr, size_t len, int behav); }
        public static readonly long SYS_MINCORE = (long)78L; // { int mincore(const void *addr, size_t len, char *vec); }
        public static readonly long SYS_GETGROUPS = (long)79L; // { int getgroups(u_int gidsetsize, gid_t *gidset); }
        public static readonly long SYS_SETGROUPS = (long)80L; // { int setgroups(u_int gidsetsize, gid_t *gidset); }
        public static readonly long SYS_GETPGRP = (long)81L; // { int getpgrp(void); }
        public static readonly long SYS_SETPGID = (long)82L; // { int setpgid(int pid, int pgid); }
        public static readonly long SYS_SETITIMER = (long)83L; // { int setitimer(u_int which, struct itimerval *itv, struct itimerval *oitv); }
        public static readonly long SYS_SWAPON = (long)85L; // { int swapon(char *name); }
        public static readonly long SYS_GETITIMER = (long)86L; // { int getitimer(u_int which, struct itimerval *itv); }
        public static readonly long SYS_GETDTABLESIZE = (long)89L; // { int getdtablesize(void); }
        public static readonly long SYS_DUP2 = (long)90L; // { int dup2(int from, int to); }
        public static readonly long SYS_FCNTL = (long)92L; // { int fcntl(int fd, int cmd, long arg); }
        public static readonly long SYS_SELECT = (long)93L; // { int select(int nd, fd_set *in, fd_set *ou, fd_set *ex, struct timeval *tv); }
        public static readonly long SYS_FSYNC = (long)95L; // { int fsync(int fd); }
        public static readonly long SYS_SETPRIORITY = (long)96L; // { int setpriority(int which, int who, int prio); }
        public static readonly long SYS_SOCKET = (long)97L; // { int socket(int domain, int type, int protocol); }
        public static readonly long SYS_CONNECT = (long)98L; // { int connect(int s, caddr_t name, int namelen); }
        public static readonly long SYS_GETPRIORITY = (long)100L; // { int getpriority(int which, int who); }
        public static readonly long SYS_BIND = (long)104L; // { int bind(int s, caddr_t name, int namelen); }
        public static readonly long SYS_SETSOCKOPT = (long)105L; // { int setsockopt(int s, int level, int name, caddr_t val, int valsize); }
        public static readonly long SYS_LISTEN = (long)106L; // { int listen(int s, int backlog); }
        public static readonly long SYS_GETTIMEOFDAY = (long)116L; // { int gettimeofday(struct timeval *tp, struct timezone *tzp); }
        public static readonly long SYS_GETRUSAGE = (long)117L; // { int getrusage(int who, struct rusage *rusage); }
        public static readonly long SYS_GETSOCKOPT = (long)118L; // { int getsockopt(int s, int level, int name, caddr_t val, int *avalsize); }
        public static readonly long SYS_READV = (long)120L; // { int readv(int fd, struct iovec *iovp, u_int iovcnt); }
        public static readonly long SYS_WRITEV = (long)121L; // { int writev(int fd, struct iovec *iovp, u_int iovcnt); }
        public static readonly long SYS_SETTIMEOFDAY = (long)122L; // { int settimeofday(struct timeval *tv, struct timezone *tzp); }
        public static readonly long SYS_FCHOWN = (long)123L; // { int fchown(int fd, int uid, int gid); }
        public static readonly long SYS_FCHMOD = (long)124L; // { int fchmod(int fd, int mode); }
        public static readonly long SYS_SETREUID = (long)126L; // { int setreuid(int ruid, int euid); }
        public static readonly long SYS_SETREGID = (long)127L; // { int setregid(int rgid, int egid); }
        public static readonly long SYS_RENAME = (long)128L; // { int rename(char *from, char *to); }
        public static readonly long SYS_FLOCK = (long)131L; // { int flock(int fd, int how); }
        public static readonly long SYS_MKFIFO = (long)132L; // { int mkfifo(char *path, int mode); }
        public static readonly long SYS_SENDTO = (long)133L; // { int sendto(int s, caddr_t buf, size_t len, int flags, caddr_t to, int tolen); }
        public static readonly long SYS_SHUTDOWN = (long)134L; // { int shutdown(int s, int how); }
        public static readonly long SYS_SOCKETPAIR = (long)135L; // { int socketpair(int domain, int type, int protocol, int *rsv); }
        public static readonly long SYS_MKDIR = (long)136L; // { int mkdir(char *path, int mode); }
        public static readonly long SYS_RMDIR = (long)137L; // { int rmdir(char *path); }
        public static readonly long SYS_UTIMES = (long)138L; // { int utimes(char *path, struct timeval *tptr); }
        public static readonly long SYS_ADJTIME = (long)140L; // { int adjtime(struct timeval *delta, struct timeval *olddelta); }
        public static readonly long SYS_SETSID = (long)147L; // { int setsid(void); }
        public static readonly long SYS_QUOTACTL = (long)148L; // { int quotactl(char *path, int cmd, int uid, caddr_t arg); }
        public static readonly long SYS_STATFS = (long)157L; // { int statfs(char *path, struct statfs *buf); }
        public static readonly long SYS_FSTATFS = (long)158L; // { int fstatfs(int fd, struct statfs *buf); }
        public static readonly long SYS_GETFH = (long)161L; // { int getfh(char *fname, struct fhandle *fhp); }
        public static readonly long SYS_GETDOMAINNAME = (long)162L; // { int getdomainname(char *domainname, int len); }
        public static readonly long SYS_SETDOMAINNAME = (long)163L; // { int setdomainname(char *domainname, int len); }
        public static readonly long SYS_UNAME = (long)164L; // { int uname(struct utsname *name); }
        public static readonly long SYS_SYSARCH = (long)165L; // { int sysarch(int op, char *parms); }
        public static readonly long SYS_RTPRIO = (long)166L; // { int rtprio(int function, pid_t pid, struct rtprio *rtp); }
        public static readonly long SYS_EXTPREAD = (long)173L; // { ssize_t extpread(int fd, void *buf, size_t nbyte, int flags, off_t offset); }
        public static readonly long SYS_EXTPWRITE = (long)174L; // { ssize_t extpwrite(int fd, const void *buf, size_t nbyte, int flags, off_t offset); }
        public static readonly long SYS_NTP_ADJTIME = (long)176L; // { int ntp_adjtime(struct timex *tp); }
        public static readonly long SYS_SETGID = (long)181L; // { int setgid(gid_t gid); }
        public static readonly long SYS_SETEGID = (long)182L; // { int setegid(gid_t egid); }
        public static readonly long SYS_SETEUID = (long)183L; // { int seteuid(uid_t euid); }
        public static readonly long SYS_PATHCONF = (long)191L; // { int pathconf(char *path, int name); }
        public static readonly long SYS_FPATHCONF = (long)192L; // { int fpathconf(int fd, int name); }
        public static readonly long SYS_GETRLIMIT = (long)194L; // { int getrlimit(u_int which, struct rlimit *rlp); } getrlimit __getrlimit_args int
        public static readonly long SYS_SETRLIMIT = (long)195L; // { int setrlimit(u_int which, struct rlimit *rlp); } setrlimit __setrlimit_args int
        public static readonly long SYS_MMAP = (long)197L; // { caddr_t mmap(caddr_t addr, size_t len, int prot, int flags, int fd, int pad, off_t pos); }
        // SYS_NOSYS = 198;  // { int nosys(void); } __syscall __syscall_args int
        public static readonly long SYS_LSEEK = (long)199L; // { off_t lseek(int fd, int pad, off_t offset, int whence); }
        public static readonly long SYS_TRUNCATE = (long)200L; // { int truncate(char *path, int pad, off_t length); }
        public static readonly long SYS_FTRUNCATE = (long)201L; // { int ftruncate(int fd, int pad, off_t length); }
        public static readonly long SYS___SYSCTL = (long)202L; // { int __sysctl(int *name, u_int namelen, void *old, size_t *oldlenp, void *new, size_t newlen); } __sysctl sysctl_args int
        public static readonly long SYS_MLOCK = (long)203L; // { int mlock(const void *addr, size_t len); }
        public static readonly long SYS_MUNLOCK = (long)204L; // { int munlock(const void *addr, size_t len); }
        public static readonly long SYS_UNDELETE = (long)205L; // { int undelete(char *path); }
        public static readonly long SYS_FUTIMES = (long)206L; // { int futimes(int fd, struct timeval *tptr); }
        public static readonly long SYS_GETPGID = (long)207L; // { int getpgid(pid_t pid); }
        public static readonly long SYS_POLL = (long)209L; // { int poll(struct pollfd *fds, u_int nfds, int timeout); }
        public static readonly long SYS___SEMCTL = (long)220L; // { int __semctl(int semid, int semnum, int cmd, union semun *arg); }
        public static readonly long SYS_SEMGET = (long)221L; // { int semget(key_t key, int nsems, int semflg); }
        public static readonly long SYS_SEMOP = (long)222L; // { int semop(int semid, struct sembuf *sops, u_int nsops); }
        public static readonly long SYS_MSGCTL = (long)224L; // { int msgctl(int msqid, int cmd, struct msqid_ds *buf); }
        public static readonly long SYS_MSGGET = (long)225L; // { int msgget(key_t key, int msgflg); }
        public static readonly long SYS_MSGSND = (long)226L; // { int msgsnd(int msqid, const void *msgp, size_t msgsz, int msgflg); }
        public static readonly long SYS_MSGRCV = (long)227L; // { int msgrcv(int msqid, void *msgp, size_t msgsz, long msgtyp, int msgflg); }
        public static readonly long SYS_SHMAT = (long)228L; // { caddr_t shmat(int shmid, const void *shmaddr, int shmflg); }
        public static readonly long SYS_SHMCTL = (long)229L; // { int shmctl(int shmid, int cmd, struct shmid_ds *buf); }
        public static readonly long SYS_SHMDT = (long)230L; // { int shmdt(const void *shmaddr); }
        public static readonly long SYS_SHMGET = (long)231L; // { int shmget(key_t key, size_t size, int shmflg); }
        public static readonly long SYS_CLOCK_GETTIME = (long)232L; // { int clock_gettime(clockid_t clock_id, struct timespec *tp); }
        public static readonly long SYS_CLOCK_SETTIME = (long)233L; // { int clock_settime(clockid_t clock_id, const struct timespec *tp); }
        public static readonly long SYS_CLOCK_GETRES = (long)234L; // { int clock_getres(clockid_t clock_id, struct timespec *tp); }
        public static readonly long SYS_NANOSLEEP = (long)240L; // { int nanosleep(const struct timespec *rqtp, struct timespec *rmtp); }
        public static readonly long SYS_MINHERIT = (long)250L; // { int minherit(void *addr, size_t len, int inherit); }
        public static readonly long SYS_RFORK = (long)251L; // { int rfork(int flags); }
        public static readonly long SYS_OPENBSD_POLL = (long)252L; // { int openbsd_poll(struct pollfd *fds, u_int nfds, int timeout); }
        public static readonly long SYS_ISSETUGID = (long)253L; // { int issetugid(void); }
        public static readonly long SYS_LCHOWN = (long)254L; // { int lchown(char *path, int uid, int gid); }
        public static readonly long SYS_LCHMOD = (long)274L; // { int lchmod(char *path, mode_t mode); }
        public static readonly long SYS_LUTIMES = (long)276L; // { int lutimes(char *path, struct timeval *tptr); }
        public static readonly long SYS_EXTPREADV = (long)289L; // { ssize_t extpreadv(int fd, struct iovec *iovp, u_int iovcnt, int flags, off_t offset); }
        public static readonly long SYS_EXTPWRITEV = (long)290L; // { ssize_t extpwritev(int fd, struct iovec *iovp,u_int iovcnt, int flags, off_t offset); }
        public static readonly long SYS_FHSTATFS = (long)297L; // { int fhstatfs(const struct fhandle *u_fhp, struct statfs *buf); }
        public static readonly long SYS_FHOPEN = (long)298L; // { int fhopen(const struct fhandle *u_fhp, int flags); }
        public static readonly long SYS_MODNEXT = (long)300L; // { int modnext(int modid); }
        public static readonly long SYS_MODSTAT = (long)301L; // { int modstat(int modid, struct module_stat* stat); }
        public static readonly long SYS_MODFNEXT = (long)302L; // { int modfnext(int modid); }
        public static readonly long SYS_MODFIND = (long)303L; // { int modfind(const char *name); }
        public static readonly long SYS_KLDLOAD = (long)304L; // { int kldload(const char *file); }
        public static readonly long SYS_KLDUNLOAD = (long)305L; // { int kldunload(int fileid); }
        public static readonly long SYS_KLDFIND = (long)306L; // { int kldfind(const char *file); }
        public static readonly long SYS_KLDNEXT = (long)307L; // { int kldnext(int fileid); }
        public static readonly long SYS_KLDSTAT = (long)308L; // { int kldstat(int fileid, struct kld_file_stat* stat); }
        public static readonly long SYS_KLDFIRSTMOD = (long)309L; // { int kldfirstmod(int fileid); }
        public static readonly long SYS_GETSID = (long)310L; // { int getsid(pid_t pid); }
        public static readonly long SYS_SETRESUID = (long)311L; // { int setresuid(uid_t ruid, uid_t euid, uid_t suid); }
        public static readonly long SYS_SETRESGID = (long)312L; // { int setresgid(gid_t rgid, gid_t egid, gid_t sgid); }
        public static readonly long SYS_AIO_RETURN = (long)314L; // { int aio_return(struct aiocb *aiocbp); }
        public static readonly long SYS_AIO_SUSPEND = (long)315L; // { int aio_suspend(struct aiocb * const * aiocbp, int nent, const struct timespec *timeout); }
        public static readonly long SYS_AIO_CANCEL = (long)316L; // { int aio_cancel(int fd, struct aiocb *aiocbp); }
        public static readonly long SYS_AIO_ERROR = (long)317L; // { int aio_error(struct aiocb *aiocbp); }
        public static readonly long SYS_AIO_READ = (long)318L; // { int aio_read(struct aiocb *aiocbp); }
        public static readonly long SYS_AIO_WRITE = (long)319L; // { int aio_write(struct aiocb *aiocbp); }
        public static readonly long SYS_LIO_LISTIO = (long)320L; // { int lio_listio(int mode, struct aiocb * const *acb_list, int nent, struct sigevent *sig); }
        public static readonly long SYS_YIELD = (long)321L; // { int yield(void); }
        public static readonly long SYS_MLOCKALL = (long)324L; // { int mlockall(int how); }
        public static readonly long SYS_MUNLOCKALL = (long)325L; // { int munlockall(void); }
        public static readonly long SYS___GETCWD = (long)326L; // { int __getcwd(u_char *buf, u_int buflen); }
        public static readonly long SYS_SCHED_SETPARAM = (long)327L; // { int sched_setparam (pid_t pid, const struct sched_param *param); }
        public static readonly long SYS_SCHED_GETPARAM = (long)328L; // { int sched_getparam (pid_t pid, struct sched_param *param); }
        public static readonly long SYS_SCHED_SETSCHEDULER = (long)329L; // { int sched_setscheduler (pid_t pid, int policy, const struct sched_param *param); }
        public static readonly long SYS_SCHED_GETSCHEDULER = (long)330L; // { int sched_getscheduler (pid_t pid); }
        public static readonly long SYS_SCHED_YIELD = (long)331L; // { int sched_yield (void); }
        public static readonly long SYS_SCHED_GET_PRIORITY_MAX = (long)332L; // { int sched_get_priority_max (int policy); }
        public static readonly long SYS_SCHED_GET_PRIORITY_MIN = (long)333L; // { int sched_get_priority_min (int policy); }
        public static readonly long SYS_SCHED_RR_GET_INTERVAL = (long)334L; // { int sched_rr_get_interval (pid_t pid, struct timespec *interval); }
        public static readonly long SYS_UTRACE = (long)335L; // { int utrace(const void *addr, size_t len); }
        public static readonly long SYS_KLDSYM = (long)337L; // { int kldsym(int fileid, int cmd, void *data); }
        public static readonly long SYS_JAIL = (long)338L; // { int jail(struct jail *jail); }
        public static readonly long SYS_SIGPROCMASK = (long)340L; // { int sigprocmask(int how, const sigset_t *set, sigset_t *oset); }
        public static readonly long SYS_SIGSUSPEND = (long)341L; // { int sigsuspend(const sigset_t *sigmask); }
        public static readonly long SYS_SIGACTION = (long)342L; // { int sigaction(int sig, const struct sigaction *act, struct sigaction *oact); }
        public static readonly long SYS_SIGPENDING = (long)343L; // { int sigpending(sigset_t *set); }
        public static readonly long SYS_SIGRETURN = (long)344L; // { int sigreturn(ucontext_t *sigcntxp); }
        public static readonly long SYS_SIGTIMEDWAIT = (long)345L; // { int sigtimedwait(const sigset_t *set,siginfo_t *info, const struct timespec *timeout); }
        public static readonly long SYS_SIGWAITINFO = (long)346L; // { int sigwaitinfo(const sigset_t *set,siginfo_t *info); }
        public static readonly long SYS___ACL_GET_FILE = (long)347L; // { int __acl_get_file(const char *path, acl_type_t type, struct acl *aclp); }
        public static readonly long SYS___ACL_SET_FILE = (long)348L; // { int __acl_set_file(const char *path, acl_type_t type, struct acl *aclp); }
        public static readonly long SYS___ACL_GET_FD = (long)349L; // { int __acl_get_fd(int filedes, acl_type_t type, struct acl *aclp); }
        public static readonly long SYS___ACL_SET_FD = (long)350L; // { int __acl_set_fd(int filedes, acl_type_t type, struct acl *aclp); }
        public static readonly long SYS___ACL_DELETE_FILE = (long)351L; // { int __acl_delete_file(const char *path, acl_type_t type); }
        public static readonly long SYS___ACL_DELETE_FD = (long)352L; // { int __acl_delete_fd(int filedes, acl_type_t type); }
        public static readonly long SYS___ACL_ACLCHECK_FILE = (long)353L; // { int __acl_aclcheck_file(const char *path, acl_type_t type, struct acl *aclp); }
        public static readonly long SYS___ACL_ACLCHECK_FD = (long)354L; // { int __acl_aclcheck_fd(int filedes, acl_type_t type, struct acl *aclp); }
        public static readonly long SYS_EXTATTRCTL = (long)355L; // { int extattrctl(const char *path, int cmd, const char *filename, int attrnamespace, const char *attrname); }
        public static readonly long SYS_EXTATTR_SET_FILE = (long)356L; // { int extattr_set_file(const char *path, int attrnamespace, const char *attrname, void *data, size_t nbytes); }
        public static readonly long SYS_EXTATTR_GET_FILE = (long)357L; // { int extattr_get_file(const char *path, int attrnamespace, const char *attrname, void *data, size_t nbytes); }
        public static readonly long SYS_EXTATTR_DELETE_FILE = (long)358L; // { int extattr_delete_file(const char *path, int attrnamespace, const char *attrname); }
        public static readonly long SYS_AIO_WAITCOMPLETE = (long)359L; // { int aio_waitcomplete(struct aiocb **aiocbp, struct timespec *timeout); }
        public static readonly long SYS_GETRESUID = (long)360L; // { int getresuid(uid_t *ruid, uid_t *euid, uid_t *suid); }
        public static readonly long SYS_GETRESGID = (long)361L; // { int getresgid(gid_t *rgid, gid_t *egid, gid_t *sgid); }
        public static readonly long SYS_KQUEUE = (long)362L; // { int kqueue(void); }
        public static readonly long SYS_KEVENT = (long)363L; // { int kevent(int fd, const struct kevent *changelist, int nchanges, struct kevent *eventlist, int nevents, const struct timespec *timeout); }
        public static readonly long SYS_KENV = (long)390L; // { int kenv(int what, const char *name, char *value, int len); }
        public static readonly long SYS_LCHFLAGS = (long)391L; // { int lchflags(char *path, int flags); }
        public static readonly long SYS_UUIDGEN = (long)392L; // { int uuidgen(struct uuid *store, int count); }
        public static readonly long SYS_SENDFILE = (long)393L; // { int sendfile(int fd, int s, off_t offset, size_t nbytes, struct sf_hdtr *hdtr, off_t *sbytes, int flags); }
        public static readonly long SYS_VARSYM_SET = (long)450L; // { int varsym_set(int level, const char *name, const char *data); }
        public static readonly long SYS_VARSYM_GET = (long)451L; // { int varsym_get(int mask, const char *wild, char *buf, int bufsize); }
        public static readonly long SYS_VARSYM_LIST = (long)452L; // { int varsym_list(int level, char *buf, int maxsize, int *marker); }
        public static readonly long SYS_EXEC_SYS_REGISTER = (long)465L; // { int exec_sys_register(void *entry); }
        public static readonly long SYS_EXEC_SYS_UNREGISTER = (long)466L; // { int exec_sys_unregister(int id); }
        public static readonly long SYS_SYS_CHECKPOINT = (long)467L; // { int sys_checkpoint(int type, int fd, pid_t pid, int retval); }
        public static readonly long SYS_MOUNTCTL = (long)468L; // { int mountctl(const char *path, int op, int fd, const void *ctl, int ctllen, void *buf, int buflen); }
        public static readonly long SYS_UMTX_SLEEP = (long)469L; // { int umtx_sleep(volatile const int *ptr, int value, int timeout); }
        public static readonly long SYS_UMTX_WAKEUP = (long)470L; // { int umtx_wakeup(volatile const int *ptr, int count); }
        public static readonly long SYS_JAIL_ATTACH = (long)471L; // { int jail_attach(int jid); }
        public static readonly long SYS_SET_TLS_AREA = (long)472L; // { int set_tls_area(int which, struct tls_info *info, size_t infosize); }
        public static readonly long SYS_GET_TLS_AREA = (long)473L; // { int get_tls_area(int which, struct tls_info *info, size_t infosize); }
        public static readonly long SYS_CLOSEFROM = (long)474L; // { int closefrom(int fd); }
        public static readonly long SYS_STAT = (long)475L; // { int stat(const char *path, struct stat *ub); }
        public static readonly long SYS_FSTAT = (long)476L; // { int fstat(int fd, struct stat *sb); }
        public static readonly long SYS_LSTAT = (long)477L; // { int lstat(const char *path, struct stat *ub); }
        public static readonly long SYS_FHSTAT = (long)478L; // { int fhstat(const struct fhandle *u_fhp, struct stat *sb); }
        public static readonly long SYS_GETDIRENTRIES = (long)479L; // { int getdirentries(int fd, char *buf, u_int count, long *basep); }
        public static readonly long SYS_GETDENTS = (long)480L; // { int getdents(int fd, char *buf, size_t count); }
        public static readonly long SYS_USCHED_SET = (long)481L; // { int usched_set(pid_t pid, int cmd, void *data, int bytes); }
        public static readonly long SYS_EXTACCEPT = (long)482L; // { int extaccept(int s, int flags, caddr_t name, int *anamelen); }
        public static readonly long SYS_EXTCONNECT = (long)483L; // { int extconnect(int s, int flags, caddr_t name, int namelen); }
        public static readonly long SYS_MCONTROL = (long)485L; // { int mcontrol(void *addr, size_t len, int behav, off_t value); }
        public static readonly long SYS_VMSPACE_CREATE = (long)486L; // { int vmspace_create(void *id, int type, void *data); }
        public static readonly long SYS_VMSPACE_DESTROY = (long)487L; // { int vmspace_destroy(void *id); }
        public static readonly long SYS_VMSPACE_CTL = (long)488L; // { int vmspace_ctl(void *id, int cmd,         struct trapframe *tframe,    struct vextframe *vframe); }
        public static readonly long SYS_VMSPACE_MMAP = (long)489L; // { int vmspace_mmap(void *id, void *addr, size_t len, int prot, int flags, int fd, off_t offset); }
        public static readonly long SYS_VMSPACE_MUNMAP = (long)490L; // { int vmspace_munmap(void *id, void *addr,    size_t len); }
        public static readonly long SYS_VMSPACE_MCONTROL = (long)491L; // { int vmspace_mcontrol(void *id, void *addr,     size_t len, int behav, off_t value); }
        public static readonly long SYS_VMSPACE_PREAD = (long)492L; // { ssize_t vmspace_pread(void *id, void *buf, size_t nbyte, int flags, off_t offset); }
        public static readonly long SYS_VMSPACE_PWRITE = (long)493L; // { ssize_t vmspace_pwrite(void *id, const void *buf, size_t nbyte, int flags, off_t offset); }
        public static readonly long SYS_EXTEXIT = (long)494L; // { void extexit(int how, int status, void *addr); }
        public static readonly long SYS_LWP_CREATE = (long)495L; // { int lwp_create(struct lwp_params *params); }
        public static readonly long SYS_LWP_GETTID = (long)496L; // { lwpid_t lwp_gettid(void); }
        public static readonly long SYS_LWP_KILL = (long)497L; // { int lwp_kill(pid_t pid, lwpid_t tid, int signum); }
        public static readonly long SYS_LWP_RTPRIO = (long)498L; // { int lwp_rtprio(int function, pid_t pid, lwpid_t tid, struct rtprio *rtp); }
        public static readonly long SYS_PSELECT = (long)499L; // { int pselect(int nd, fd_set *in, fd_set *ou, fd_set *ex, const struct timespec *ts,    const sigset_t *sigmask); }
        public static readonly long SYS_STATVFS = (long)500L; // { int statvfs(const char *path, struct statvfs *buf); }
        public static readonly long SYS_FSTATVFS = (long)501L; // { int fstatvfs(int fd, struct statvfs *buf); }
        public static readonly long SYS_FHSTATVFS = (long)502L; // { int fhstatvfs(const struct fhandle *u_fhp, struct statvfs *buf); }
        public static readonly long SYS_GETVFSSTAT = (long)503L; // { int getvfsstat(struct statfs *buf,          struct statvfs *vbuf, long vbufsize, int flags); }
        public static readonly long SYS_OPENAT = (long)504L; // { int openat(int fd, char *path, int flags, int mode); }
        public static readonly long SYS_FSTATAT = (long)505L; // { int fstatat(int fd, char *path,     struct stat *sb, int flags); }
        public static readonly long SYS_FCHMODAT = (long)506L; // { int fchmodat(int fd, char *path, int mode, int flags); }
        public static readonly long SYS_FCHOWNAT = (long)507L; // { int fchownat(int fd, char *path, int uid, int gid, int flags); }
        public static readonly long SYS_UNLINKAT = (long)508L; // { int unlinkat(int fd, char *path, int flags); }
        public static readonly long SYS_FACCESSAT = (long)509L; // { int faccessat(int fd, char *path, int amode, int flags); }
        public static readonly long SYS_MQ_OPEN = (long)510L; // { mqd_t mq_open(const char * name, int oflag, mode_t mode, struct mq_attr *attr); }
        public static readonly long SYS_MQ_CLOSE = (long)511L; // { int mq_close(mqd_t mqdes); }
        public static readonly long SYS_MQ_UNLINK = (long)512L; // { int mq_unlink(const char *name); }
        public static readonly long SYS_MQ_GETATTR = (long)513L; // { int mq_getattr(mqd_t mqdes, struct mq_attr *mqstat); }
        public static readonly long SYS_MQ_SETATTR = (long)514L; // { int mq_setattr(mqd_t mqdes, const struct mq_attr *mqstat, struct mq_attr *omqstat); }
        public static readonly long SYS_MQ_NOTIFY = (long)515L; // { int mq_notify(mqd_t mqdes, const struct sigevent *notification); }
        public static readonly long SYS_MQ_SEND = (long)516L; // { int mq_send(mqd_t mqdes, const char *msg_ptr, size_t msg_len, unsigned msg_prio); }
        public static readonly long SYS_MQ_RECEIVE = (long)517L; // { ssize_t mq_receive(mqd_t mqdes, char *msg_ptr, size_t msg_len, unsigned *msg_prio); }
        public static readonly long SYS_MQ_TIMEDSEND = (long)518L; // { int mq_timedsend(mqd_t mqdes, const char *msg_ptr, size_t msg_len, unsigned msg_prio, const struct timespec *abs_timeout); }
        public static readonly long SYS_MQ_TIMEDRECEIVE = (long)519L; // { ssize_t mq_timedreceive(mqd_t mqdes, char *msg_ptr, size_t msg_len, unsigned *msg_prio, const struct timespec *abs_timeout); }
        public static readonly long SYS_IOPRIO_SET = (long)520L; // { int ioprio_set(int which, int who, int prio); }
        public static readonly long SYS_IOPRIO_GET = (long)521L; // { int ioprio_get(int which, int who); }
        public static readonly long SYS_CHROOT_KERNEL = (long)522L; // { int chroot_kernel(char *path); }
        public static readonly long SYS_RENAMEAT = (long)523L; // { int renameat(int oldfd, char *old, int newfd, char *new); }
        public static readonly long SYS_MKDIRAT = (long)524L; // { int mkdirat(int fd, char *path, mode_t mode); }
        public static readonly long SYS_MKFIFOAT = (long)525L; // { int mkfifoat(int fd, char *path, mode_t mode); }
        public static readonly long SYS_MKNODAT = (long)526L; // { int mknodat(int fd, char *path, mode_t mode, dev_t dev); }
        public static readonly long SYS_READLINKAT = (long)527L; // { int readlinkat(int fd, char *path, char *buf, size_t bufsize); }
        public static readonly long SYS_SYMLINKAT = (long)528L; // { int symlinkat(char *path1, int fd, char *path2); }
        public static readonly long SYS_SWAPOFF = (long)529L; // { int swapoff(char *name); }
        public static readonly long SYS_VQUOTACTL = (long)530L; // { int vquotactl(const char *path, struct plistref *pref); }
        public static readonly long SYS_LINKAT = (long)531L; // { int linkat(int fd1, char *path1, int fd2, char *path2, int flags); }
        public static readonly long SYS_EACCESS = (long)532L; // { int eaccess(char *path, int flags); }
        public static readonly long SYS_LPATHCONF = (long)533L; // { int lpathconf(char *path, int name); }
        public static readonly long SYS_VMM_GUEST_CTL = (long)534L; // { int vmm_guest_ctl(int op, struct vmm_guest_options *options); }
        public static readonly long SYS_VMM_GUEST_SYNC_ADDR = (long)535L; // { int vmm_guest_sync_addr(long *dstaddr, long *srcaddr); }
        public static readonly long SYS_PROCCTL = (long)536L; // { int procctl(idtype_t idtype, id_t id, int cmd, void *data); }
        public static readonly long SYS_CHFLAGSAT = (long)537L; // { int chflagsat(int fd, const char *path, int flags, int atflags);}
        public static readonly long SYS_PIPE2 = (long)538L; // { int pipe2(int *fildes, int flags); }
        public static readonly long SYS_UTIMENSAT = (long)539L; // { int utimensat(int fd, const char *path, const struct timespec *ts, int flags); }
        public static readonly long SYS_FUTIMENS = (long)540L; // { int futimens(int fd, const struct timespec *ts); }
        public static readonly long SYS_ACCEPT4 = (long)541L; // { int accept4(int s, caddr_t name, int *anamelen, int flags); }
        public static readonly long SYS_LWP_SETNAME = (long)542L; // { int lwp_setname(lwpid_t tid, const char *name); }
        public static readonly long SYS_PPOLL = (long)543L; // { int ppoll(struct pollfd *fds, u_int nfds, const struct timespec *ts, const sigset_t *sigmask); }
        public static readonly long SYS_LWP_SETAFFINITY = (long)544L; // { int lwp_setaffinity(pid_t pid, lwpid_t tid, const cpumask_t *mask); }
        public static readonly long SYS_LWP_GETAFFINITY = (long)545L; // { int lwp_getaffinity(pid_t pid, lwpid_t tid, cpumask_t *mask); }
        public static readonly long SYS_LWP_CREATE2 = (long)546L; // { int lwp_create2(struct lwp_params *params, const cpumask_t *mask); }
    }
}}}}}}